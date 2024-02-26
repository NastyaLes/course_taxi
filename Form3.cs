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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
        }

        private void tariffBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tariffBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.taxiDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiDataSet.tariff". При необходимости она может быть перемещена или удалена.
            this.tariffTableAdapter.Fill(this.taxiDataSet.tariff);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
