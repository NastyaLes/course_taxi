using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Библиотеки для карты
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
using System.Device.Location;

namespace Такси
{
    public partial class Map : Form
    {
        public Map()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void gmap_Load(object sender, EventArgs e)
        {
            //настройки для компонента GMap
            gmap.Bearing = 0; //поворот карты на указанный радиус
            gmap.CanDragMap = true; //если параметр установлен в True, пользователь может перетаскивать
                                    //карту с помощью правой кнопки мыши
            gmap.DragButton = MouseButtons.Left; //перетаскивание карты осуществляется
                                                 //левой клавишей мыши (по умолчанию - правая)
            gmap.GrayScaleMode = true; //градация серого
            gmap.MarkersEnabled = true; //все маркеры будут показаны
            gmap.MarkersEnabled = true; //если параметр установлен в True, любые маркеры, заданные
                                        //вручную, будут показаны
            gmap.MaxZoom = 18; //значение максимального приближения
            gmap.MinZoom = 2; //значение минимального приближения
            gmap.MouseWheelZoomType = MouseWheelZoomType.MousePositionAndCenter; //устнавливает центр приближения/удаления
                                                                                 //для курсора мыши
            gmap.NegativeMode = false; //отключение негативного режима
            gmap.PolygonsEnabled = true; //разрешение полигонов
            gmap.RoutesEnabled = true; //разрешение маршрутов
            gmap.ShowTileGridLines = false; //скрытие внешней сетки карты с заголовками
            gmap.Zoom = 16; //при загрузке карты будет использоваться 16-кратное приближение
            gmap.ShowCenter = false; //красный крестик по центру
            gmap.MapProvider = GMapProviders.GoogleMap; //чья карта используется
            GMaps.Instance.Mode = AccessMode.ServerOnly; //доступ будет только по серверу
            gmap.Position = new PointLatLng(60.02403, 30.22882); //загрузка точки на карте, с которой начинаем стартовать
            gmap.Overlays.Add(PositionForUser);
        }


        bool Flag = false;
        int Count = 0;
        string MyLocation;
        GMapOverlay PositionForUser = new GMapOverlay("PositionForUser");
        GeoCoordinate MarkerClick;
        //Добавление маркера по двойному клику ЛКМ по карте
        private void gmap_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //Широта - latitude - lat - с севера на юг
                double x = gmap.FromLocalToLatLng(e.X, e.Y).Lat;
                //Долгота - longitude - lng - с запада на восток
                double y = gmap.FromLocalToLatLng(e.X, e.Y).Lng;
                MarkerClick = new GeoCoordinate(x, y);

                // Добавляем метку на слой
                GMarkerGoogle MarkerWithMyPosition = new GMarkerGoogle(new PointLatLng(x, y), GMarkerGoogleType.arrow);
                MarkerWithMyPosition.ToolTip = new GMapRoundedToolTip(MarkerWithMyPosition);
                MarkerWithMyPosition.ToolTipText = "Мое местоположение";
                PositionForUser.Markers.Add(MarkerWithMyPosition);
                Flag = true;
                Count++;
                if (Count == 1)
                {
                    label3.Text = "Отметьте место, до которого вам нужно добраться";
                    MyLocation = x.ToString() + ' ' + y.ToString();
                }
                else if (Count == 2)
                {
                    Count = 0;
                    label3.Text = "Отметьте свое местоположение";
                    PositionForUser.Markers.Clear();
                    Form4 f4 = new Form4();
                    f4.Txt1 = MyLocation;
                    f4.Txt2 = x.ToString() + ' ' + y.ToString();
                    f4.Txt3 = textBox4.Text;
                    f4.ShowDialog();
                }

            }
        }
        public double km;
        GeoCoordinate MoveCursor;
        //координаты курсора
        private void gmap_MouseMove(object sender, MouseEventArgs e)
        {
            //Широта - latitude - lat - с севера на юг
            double x = gmap.FromLocalToLatLng(e.X, e.Y).Lat;
            //Долгота - longitude - lng - с запада на восток
            double y = gmap.FromLocalToLatLng(e.X, e.Y).Lng;

            textBox1.Text = x.ToString();
            textBox2.Text = y.ToString();
            if (Flag)
            {

                MoveCursor = new GeoCoordinate(x, y);
                //расстояние между точками
                double distanse = MarkerClick.GetDistanceTo(MoveCursor);
                //округление расстояния
                distanse = Math.Ceiling(distanse);
                //вывод расстояния в метры

                km = distanse / 1000;

                textBox4.Text = km.ToString();
            }
            else
            {
                textBox4.Text = "0";
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                //инициализация новой переменной класса SaveFileDialog,
                //открывающий диалоговое окно для сохранения файла. 
                using (SaveFileDialog dialog = new SaveFileDialog())
                {
                    //задаем текущую строку фильтра имен файлов,
                    //которая определяет варианты, доступные в поле 
                    //"Сохранить как тип файла" или "Файлы типа"
                    //диалогового окна.                    
                    dialog.Filter = "PNG (*.png)|*.png";

                    //задаем строку, содержащую имя файла,
                    //выбранное в диалоговом  окне файла.
                    dialog.FileName = "GMap.NET image";

                    //создаем новое изображение и
                    //передаем компонент с картой.
                    Image image = gmap.ToImage();

                    if (image != null)
                    {
                        using (image)
                        {
                            //Запускаем общее диалоговое окно с
                            //заданным по умолчанию владельцем.                          
                            //Данное окно возвращает объект
                            //System.Windows.Forms.DialogResult.OK,
                            //если пользователь нажимает кнопку
                            //ОК в диалоговом окне; в противном случае 
                            //— объект System.Windows.Forms.DialogResult.Cancel.
                            //Если пользователь нажал ОК, то идем дальше.
                            if (dialog.ShowDialog() == DialogResult.OK)
                            {
                                //Заносим в переменную имя файла введенное 
                                //в диалоговом окне.
                                string fileName = dialog.FileName;

                                //Выполняем проверку:
                                //был ли задан формат изображения карты,
                                //если нет, то добавляем после имени
                                //расширение файла.
                                if (!fileName.EndsWith(".png",
                                    StringComparison.OrdinalIgnoreCase))
                                {
                                    fileName += ".png";
                                }
                                //Выполняем сохранение изображения карты.
                                image.Save(fileName);

                                //Выводим сообщение об успешном сохранении 
                                //и пути к данному изображению карты.
                                MessageBox.Show("Карта успешно сохранена в директории: "
                                    + Environment.NewLine
                                    + dialog.FileName, "GMap.NET",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Asterisk);
                            }
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                //Если на одном из этапов сохранения произошла ошибка 
                MessageBox.Show("Ошибка при сохранении карты: "
                    + Environment.NewLine
                    + exception.Message,
                    "GMap.NET",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Hand);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы точно хотите выйти из программы?", "Сообщение", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, 
                MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes)
                Close();
        }
    }
}
