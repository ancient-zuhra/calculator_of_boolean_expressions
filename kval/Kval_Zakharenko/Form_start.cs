using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kval_Zakharenko
{
    public partial class Form_start : Form
    {
        Калькулятор frmcal = new Калькулятор();
        public Form_start()
        {
            InitializeComponent();
        }
        
        private void label9_Click(object sender, EventArgs e)
        {
            frmcal.Show();
        }

        private void label9_MouseHover(object sender, EventArgs e)
        {
            label9.ForeColor = Color.Red;
            Cursor cursor = Cursors.Hand;
            this.Cursor = cursor;
        }

        private void label9_MouseLeave(object sender, EventArgs e)
        {
            label9.ForeColor = Color.Black;

            Cursor cursor = Cursors.Arrow;
            this.Cursor = cursor;
        }
    }
}
