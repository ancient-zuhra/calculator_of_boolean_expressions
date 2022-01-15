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
    public partial class elektrosch : Form
    {
        public elektrosch()
        {
            InitializeComponent();
        }
        Graphics gr;
        void draw_conun(double x,double y, int colzm,int colvir)
        {
            gr = pictureBox1.CreateGraphics();
            double width = pictureBox1.Width / colzm,height=pictureBox1.Height/colvir;

        }
        private void elektrosch_Load(object sender, EventArgs e)
        {

        }
    }
}
