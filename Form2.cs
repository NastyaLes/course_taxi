using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Такси
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
        }

        private void driverBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.driverBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.taxiDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiDataSet.tariff". При необходимости она может быть перемещена или удалена.
            this.tariffTableAdapter.Fill(this.taxiDataSet.tariff);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiDataSet.driver". При необходимости она может быть перемещена или удалена.
            this.driverTableAdapter.Fill(this.taxiDataSet.driver);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
