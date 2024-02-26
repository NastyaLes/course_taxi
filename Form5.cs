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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            timer1.Interval = 2000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            Map f1 = new Map();
            f1.ShowDialog();
            Close();
        }
    }
}
