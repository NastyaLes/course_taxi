using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Такси
{
    public partial class Form4 : Form
    {
        DataBaseConnection database = new DataBaseConnection();
        public Form4()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void orderrBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.orderrBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.taxiDataSet);
        }
        public string Txt1
        {
            get { return Txt_from.Text; } //получить
            set { Txt_from.Text = value; } //установить
        }
        public string Txt2
        {
            get { return Txt_in.Text; } //получить
            set { Txt_in.Text = value; } //установить
        }
        public string Txt3
        {
            get { return Lbl_km.Text; } //получить
            set { Lbl_km.Text = value; } //установить
        }

        bool proverka = false;
        double summa = 0;

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiDataSet.tariff". При необходимости она может быть перемещена или удалена.
            this.tariffTableAdapter.Fill(this.taxiDataSet.tariff);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiDataSet.driver". При необходимости она может быть перемещена или удалена.
            this.driverTableAdapter.Fill(this.taxiDataSet.driver);
            textBox1.Select();
            //Условно примем среднюю скорость автомобиля за 25 км/час
            //Значит, за 1 минуту он проезжает примерно 0,417 км
            //Поделим эту цифру на полученные километры, чтобы узнать количество минут, которые придутся на поездку
            //И умножим на прайс в минуту
            if (Txt_from.Text != String.Empty && Txt_in.Text != String.Empty)
            {
                proverka = true;
                summa = (int)Math.Round(Convert.ToDouble(Lbl_km.Text) / 0.417) * 18;
                Lbl_price.Text = summa.ToString();
                DeleteButton.Visible = false;
                fioTextBox.Visible = false;
                Btn_next.Visible = false;
                Btn_last.Visible = false;
                Txt_gender.Visible = false;
                Btn_nnnext.Visible = false;
                Btn_lllast.Visible = false;
                label10.Visible = false;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //Валидация
            if (!Regex.IsMatch(textBox1.Text, "[А-Яа-я]+$"))
            {
                MessageBox.Show("Пожалуйста, введите имя правильно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Select();
                return;
            }

            if (!Regex.IsMatch(textBox2.Text, "^[+][7][0-9]{7,14}$"))
            {
                MessageBox.Show("Пожалуйста, введите номер телефона правильно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Select();
                return;
            }

            if (string.IsNullOrEmpty(Txt_from.Text))
            {
                MessageBox.Show("Пожалуйста, выберите адрес", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Txt_from.Select();
                return;
            }

            if (string.IsNullOrEmpty(Txt_in.Text))
            {
                MessageBox.Show("Пожалуйста, выберите адрес", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Txt_in.Select();
                return;
            }
            if (checkBox1.Checked == true && checkBox2.Checked == true)
            {
                MessageBox.Show("Нельзя использовать две опции одновременно, выберите одну из них", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string mySQL = string.Empty;
            if (checkBox2.Checked == true)
            {
                mySQL += "INSERT INTO dbo.orderr (client_name, client_tel, date_orderr, address_from, address_to, price, driver_id, comm) ";
                mySQL += "VALUES ('" + textBox1.Text + "','" + textBox2.Text + "', getdate(), '" + Txt_from.Text + "', '" + Txt_in.Text + "', " + (int)Convert.ToDouble(Lbl_price.Text) + ", (SELECT id_driver FROM dbo.driver WHERE fio = '" + fioTextBox.Text + "' AND statuss = 'свободен'), '" + Txt_comm.Text + "')";
            }
            else if (checkBox1.Checked == true)
            {
                mySQL += "INSERT INTO dbo.orderr (client_name, client_tel, date_orderr, address_from, address_to, price, driver_id, comm) ";
                mySQL += "VALUES ('" + textBox1.Text + "','" + textBox2.Text + "', getdate(), '" + Txt_from.Text + "', '" + Txt_in.Text + "', " + (int)Convert.ToDouble(Lbl_price.Text) + ", (SELECT TOP 1 id_driver FROM dbo.driver JOIN dbo.tariff ON dbo.tariff.id_tariff = dbo.driver.tariff_id WHERE gender = '" + Txt_gender.Text + "' AND dbo.tariff.ttype = '" + Txt_ttype.Text + "' AND statuss = 'свободен'), '" + Txt_comm.Text + "')";
            }
            else if (checkBox1.Checked == false && checkBox2.Checked == false)
            {
                mySQL += "INSERT INTO dbo.orderr (client_name, client_tel, date_orderr, address_from, address_to, price, driver_id, comm) ";
                mySQL += "VALUES ('" + textBox1.Text + "','" + textBox2.Text + "', getdate(), '" + Txt_from.Text + "', '" + Txt_in.Text + "', " + (int)Convert.ToDouble(Lbl_price.Text) + ", (SELECT TOP 1 id_driver FROM dbo.driver JOIN dbo.tariff ON dbo.tariff.id_tariff = dbo.driver.tariff_id WHERE dbo.tariff.ttype = '" + Txt_ttype.Text + "' AND statuss = 'свободен'), '" + Txt_comm.Text + "')";
            }
            database.openConnection(); //открываем связь с базой данных
            SqlCommand commandAddNewOrderr = new SqlCommand(mySQL, database.getConnection()); //выполнение запроса
            commandAddNewOrderr.ExecuteNonQuery();
            MessageBox.Show("Заказ принят, ожидайте такси", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            database.closeConnection(); //закрываем связь
            DeleteButton.Visible = true;
        }


       private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Txt_gender.Visible = true;
                Btn_nnnext.Visible = true;
                Btn_lllast.Visible = true;
            }
            else
            {
                Txt_gender.Visible = false;
                Btn_nnnext.Visible = false;
                Btn_lllast.Visible = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                fioTextBox.Visible = true;
                Btn_next.Visible = true;
                Btn_last.Visible = true;
                Txt_ttype.Enabled = false;
                Lbl_price.Text = "0";
                label10.Visible = true;
                label10.Text = "(Цена поездки зависит от тарифа водителя)";
            }
            else
            {
                fioTextBox.Visible = false;
                Btn_next.Visible = false;
                Btn_last.Visible = false;
                Txt_ttype.Enabled = true;
                Lbl_price.Text = summa.ToString();
                label10.Visible = false;
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string mySQL = string.Empty;
            mySQL += "DELETE FROM orderr WHERE client_tel = '" + textBox2.Text + "'";

            database.openConnection(); //открываем связь с базой данных
            SqlCommand commandAddNewOrderr = new SqlCommand(mySQL, database.getConnection()); //выполнение запроса
            commandAddNewOrderr.ExecuteNonQuery();
            MessageBox.Show("Запись была удалена", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            database.closeConnection(); //закрываем связь

            Close();
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
        private void Btn_next_Click(object sender, EventArgs e)
        {
            driverBindingSource.MoveNext();
        }

        private void Btn_last_Click(object sender, EventArgs e)
        {
            driverBindingSource.MovePrevious();
        }

        private void Btn_nnext_Click(object sender, EventArgs e)
        {
            tariffBindingSource.MoveNext();
        }

        private void Btn_llast_Click(object sender, EventArgs e)
        {
            tariffBindingSource.MovePrevious();
        }

        private void Btn_nnnext_Click(object sender, EventArgs e)
        {
            driverBindingSource.MoveNext();
        }

        private void Btn_lllast_Click(object sender, EventArgs e)
        {
            driverBindingSource.MovePrevious();
        }

        private void Txt_ttype_TextChanged(object sender, EventArgs e)
        {
            if (proverka == false)
            {
                Lbl_price.Text = "0";
                label10.Visible = true;
                label10.Text = "(Цену поездки озвучит водитель)";
            }
            else
            {
                switch (Txt_ttype.Text)
                {
                    case "Эконом":
                        summa = (int)Math.Round(Convert.ToDouble(Lbl_km.Text) / 0.417) * 18;
                        Lbl_price.Text = summa.ToString();
                        break;
                    case "Комфорт":
                        summa = (int)Math.Round(Convert.ToDouble(Lbl_km.Text) / 0.417) * 28;
                        Lbl_price.Text = summa.ToString();
                        break;
                    case "Business":
                        summa = (int)Math.Round(Convert.ToDouble(Lbl_km.Text) / 0.417) * 86;
                        Lbl_price.Text = summa.ToString();
                        break;
                    case "Комфорт+":
                        summa = (int)Math.Round(Convert.ToDouble(Lbl_km.Text) / 0.417) * 41;
                        Lbl_price.Text = summa.ToString();
                        break;
                    case "Детский":
                        summa = (int)Math.Round(Convert.ToDouble(Lbl_km.Text) / 0.417) * 26;
                        Lbl_price.Text = summa.ToString();
                        break;
                    case "Минивэн":
                        summa = (int)Math.Round(Convert.ToDouble(Lbl_km.Text) / 0.417) * 100;
                        Lbl_price.Text = summa.ToString();
                        break;
                    case "Специальный":
                        summa = (int)Math.Round(Convert.ToDouble(Lbl_km.Text) / 0.417) * 13;
                        Lbl_price.Text = summa.ToString();
                        break;
                }
            }                
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
