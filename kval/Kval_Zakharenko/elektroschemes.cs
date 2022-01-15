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
    public partial class Elektroschemes : Form
    {
        public Elektroschemes()
        {
            InitializeComponent();
        }
        Graphics gr;
        bool a=false, b=false,res=false;
        double x, y,lengtha=20;

        void draw_conun(double x,double y, double col)
        {
            float width = pictureBox1.Width / (float)col, height = pictureBox1.Height / (float)col;
            gr = pictureBox1.CreateGraphics();
            float fl_lengtha = (float)lengtha;
            float fl_x = (float)x; float fl_y = (float)y;
                        
            gr.DrawLine(Pens.Black, fl_x + fl_lengtha, fl_y + (height / 3), fl_x + width / 4, fl_y + (height / 3));
            gr.DrawLine(Pens.Black, fl_x + fl_lengtha, fl_y + ((2*height) / 3), fl_x + width / 4, fl_y + ((2*height) / 3));

            gr.FillRectangle(Brushes.White, fl_x, fl_y + (height / 3) - fl_lengtha, 2 * fl_lengtha, 2 * fl_lengtha);
            gr.FillRectangle(Brushes.White, fl_x, fl_y + ((2 * height) / 3) - fl_lengtha, 2 * fl_lengtha, 2 * fl_lengtha);
            gr.DrawRectangle(Pens.Black, fl_x, fl_y + (height / 3) - fl_lengtha, 2 * fl_lengtha, 2 * fl_lengtha);
            gr.DrawRectangle(Pens.Black, fl_x, fl_y + ((2 * height) / 3) - fl_lengtha, 2 * fl_lengtha, 2 * fl_lengtha);

            gr.DrawRectangle(Pens.Black, fl_x + (width / 4), fl_y + fl_lengtha, width / 2, height - 2*fl_lengtha);
            gr.DrawLine(Pens.Black, fl_x + (width * 3) / 4, fl_y + height / 2, fl_x + width-30, fl_y + height / 2);
            gr.FillRectangle(Brushes.White, fl_x + width - 60, fl_y - 30 + height / 2, 60, 60);
            gr.DrawRectangle(Pens.Black, fl_x + width - 60, fl_y - 30 + height / 2, 60, 60);

            gr.DrawString("&", new Font("Arial", 40), Brushes.Black, fl_x - 50 + width / 2, fl_y - 50 + height / 2);
        }
        void draw_not_conun(double x, double y, double col)
        {
            float width = pictureBox1.Width / (float)col, height = pictureBox1.Height / (float)col;
            gr = pictureBox1.CreateGraphics();
            float fl_lengtha = (float)lengtha;
            float fl_x = (float)x; float fl_y = (float)y;
            gr.DrawLine(Pens.Black, fl_x + fl_lengtha, fl_y + (height / 3), fl_x + width / 4, fl_y + (height / 3));
            gr.DrawLine(Pens.Black, fl_x + fl_lengtha, fl_y + ((2 * height) / 3), fl_x + width / 4, fl_y + ((2 * height) / 3));

            gr.FillRectangle(Brushes.White, fl_x, fl_y + (height / 3) - fl_lengtha, 2 * fl_lengtha, 2 * fl_lengtha);
            gr.FillRectangle(Brushes.White, fl_x, fl_y + ((2 * height) / 3) - fl_lengtha, 2 * fl_lengtha, 2 * fl_lengtha);
            gr.DrawRectangle(Pens.Black, fl_x, fl_y + (height / 3) - fl_lengtha, 2 * fl_lengtha, 2 * fl_lengtha);
            gr.DrawRectangle(Pens.Black, fl_x, fl_y + ((2 * height) / 3) - fl_lengtha, 2 * fl_lengtha, 2 * fl_lengtha);

            gr.FillEllipse(Brushes.White, fl_x + width / 4 - (fl_lengtha / 2), fl_y + (height / 3) - (fl_lengtha / 2), fl_lengtha, fl_lengtha);
            gr.DrawEllipse(Pens.Black, fl_x + width / 4 - (fl_lengtha / 2), fl_y + (height / 3) - (fl_lengtha / 2), fl_lengtha, fl_lengtha);
            gr.FillEllipse(Brushes.White, fl_x + width / 4 - (fl_lengtha / 2), fl_y + (2*height / 3) - (fl_lengtha / 2), fl_lengtha, fl_lengtha);
            gr.DrawEllipse(Pens.Black, fl_x + width / 4 - (fl_lengtha / 2), fl_y + (2*height / 3) - (fl_lengtha / 2), fl_lengtha, fl_lengtha);

            gr.DrawRectangle(Pens.Black, fl_x + (width / 4), fl_y + fl_lengtha, width / 2, height - 2 * fl_lengtha);
            gr.DrawLine(Pens.Black, fl_x + (width * 3) / 4, fl_y + height / 2, fl_x + width - 30, fl_y + height / 2);
            gr.FillRectangle(Brushes.White, fl_x + width - 60, fl_y - 30 + height / 2, 60, 60);
            gr.DrawRectangle(Pens.Black, fl_x + width - 60, fl_y - 30 + height / 2, 60, 60);
            
            gr.DrawString("&", new Font("Arial", 40), Brushes.Black, fl_x - 50 + width / 2, fl_y - 50 + height / 2);
        }

        void draw_disun(double x, double y,double col)
        {
            float width = pictureBox1.Width / (float)col, height = pictureBox1.Height / (float)col;
            gr = pictureBox1.CreateGraphics();
            float fl_lengtha = (float)lengtha;
            float fl_x = (float)x; float fl_y = (float)y;           
            gr.DrawLine(Pens.Black, fl_x + fl_lengtha, fl_y + (height / 3), fl_x + width / 4, fl_y + (height / 3));
            gr.DrawLine(Pens.Black, fl_x + fl_lengtha, fl_y + ((2 * height) / 3), fl_x + width / 4, fl_y + ((2 * height) / 3));

            gr.FillRectangle(Brushes.White, fl_x, fl_y + (height / 3) - fl_lengtha, 2 * fl_lengtha, 2 * fl_lengtha);
            gr.FillRectangle(Brushes.White, fl_x, fl_y + ((2 * height) / 3) - fl_lengtha, 2 * fl_lengtha, 2 * fl_lengtha);
            gr.DrawRectangle(Pens.Black, fl_x, fl_y + (height / 3) - fl_lengtha, 2 * fl_lengtha, 2 * fl_lengtha);
            gr.DrawRectangle(Pens.Black, fl_x, fl_y + ((2 * height) / 3) - fl_lengtha, 2 * fl_lengtha, 2 * fl_lengtha);

            gr.DrawRectangle(Pens.Black, fl_x + (width / 4), fl_y + fl_lengtha, width / 2, height - 2 * fl_lengtha);
            gr.DrawLine(Pens.Black, fl_x + (width * 3) / 4, fl_y + height / 2, fl_x + width - 30, fl_y + height / 2);

            gr.FillRectangle(Brushes.White, fl_x + width - 60, fl_y - 30 + height / 2, 60, 60);
            gr.DrawRectangle(Pens.Black, fl_x + width - 60, fl_y - 30 + height / 2, 60, 60);

            gr.DrawString("A", new Font("Arial", 16), Brushes.Black, fl_x, fl_y + (height / 3) - fl_lengtha - 20);
            gr.DrawString("B", new Font("Arial", 16), Brushes.Black, fl_x, fl_y + ((2 * height) / 3) - fl_lengtha - 20);
            gr.DrawString(Encoding.UTF8.GetString(Encoding.Convert(Encoding.Unicode, Encoding.UTF8, Encoding.Unicode.GetBytes("\u2265")))+"1", new Font("Arial", 40), Brushes.Black, fl_x - 50 + width / 2, fl_y - 50 + height / 2);
        }
        void draw_connected_disun(double x, double y, double col)
        {
            float width = pictureBox1.Width / (float)col, height = pictureBox1.Height / (float)col;
            gr = pictureBox1.CreateGraphics();
            float fl_lengtha = (float)lengtha;
            float fl_x = (float)x; float fl_y = (float)y;
            gr.DrawLine(Pens.Black, fl_x - width/10, fl_y + (height / 3), fl_x + width / 4, fl_y + (height / 3));
            gr.DrawLine(Pens.Black, fl_x - width/10, fl_y + ((2 * height) / 3), fl_x + width / 4, fl_y + ((2 * height) / 3));

            gr.DrawLine(Pens.Black, fl_x - width / 10, fl_y + ((2 * height) / 3), fl_x - width / 10, fl_y + ((3 * height) / 3));
            gr.DrawLine(Pens.Black, fl_x - width / 10, fl_y + (( height) / 3), fl_x - width / 10, fl_y);

            gr.DrawRectangle(Pens.Black, fl_x + (width / 4), fl_y + fl_lengtha, width / 2, height - 2 * fl_lengtha);
            gr.DrawLine(Pens.Black, fl_x + (width * 3) / 4, fl_y + height / 2, fl_x + width - 30, fl_y + height / 2);

            gr.FillRectangle(Brushes.White, fl_x + width - 60, fl_y - 30 + height / 2, 60, 60);
            gr.DrawRectangle(Pens.Black, fl_x + width - 60, fl_y - 30 + height / 2, 60, 60);      
            gr.DrawString(Encoding.UTF8.GetString(Encoding.Convert(Encoding.Unicode, Encoding.UTF8, Encoding.Unicode.GetBytes("\u2265"))) + "1", new Font("Arial", 40), Brushes.Black, fl_x - 50 + width / 2, fl_y - 50 + height / 2);
        }
        void draw_impl(double x, double y,double col)
        {
            float width = pictureBox1.Width / (float)col, height = pictureBox1.Height / (float)col;
            gr = pictureBox1.CreateGraphics();
            float fl_lengtha = (float)lengtha;
            float fl_x = (float)x; float fl_y = (float)y;
            
            gr.DrawLine(Pens.Black, fl_x + fl_lengtha, fl_y + (height / 3), fl_x + width / 4, fl_y + (height / 3));
            gr.DrawLine(Pens.Black, fl_x + fl_lengtha, fl_y + ((2 * height) / 3), fl_x + width / 4, fl_y + ((2 * height) / 3));
            gr.DrawRectangle(Pens.Black, fl_x + (width / 4), fl_y + fl_lengtha, width / 2, height - 2 * fl_lengtha);
            gr.DrawLine(Pens.Black, fl_x + (width * 3) / 4, fl_y + height / 2, fl_x + width - 30, fl_y + height / 2);

            //gr.FillEllipse(Brushes.White, fl_x + (3*width) / 4 - (fl_lengtha / 2), fl_y + (height / 2) - (fl_lengtha / 2), fl_lengtha, fl_lengtha);
            //gr.DrawEllipse(Pens.Black, fl_x + (3 * width) / 4 - (fl_lengtha / 2), fl_y + (height / 2) - (fl_lengtha / 2), fl_lengtha, fl_lengtha);
            gr.FillRectangle(Brushes.White, fl_x, fl_y + (height / 3) - fl_lengtha, 2 * fl_lengtha, 2 * fl_lengtha);
            gr.FillRectangle(Brushes.White, fl_x, fl_y + ((2 * height) / 3) - fl_lengtha, 2 * fl_lengtha, 2 * fl_lengtha);
            gr.DrawRectangle(Pens.Black, fl_x, fl_y + (height / 3) - fl_lengtha, 2 * fl_lengtha, 2 * fl_lengtha);
            gr.DrawRectangle(Pens.Black, fl_x, fl_y + ((2 * height) / 3) - fl_lengtha, 2 * fl_lengtha, 2 * fl_lengtha);

            gr.FillEllipse(Brushes.White, fl_x + width / 4 - (fl_lengtha / 2), fl_y + (height / 3) - (fl_lengtha / 2), fl_lengtha, fl_lengtha);
            gr.DrawEllipse(Pens.Black, fl_x + width / 4 - (fl_lengtha / 2), fl_y + (height / 3) - (fl_lengtha / 2), fl_lengtha, fl_lengtha);

            gr.FillRectangle(Brushes.White, fl_x + width - 60, fl_y - 30 + height / 2, 60, 60);
            gr.DrawRectangle(Pens.Black, fl_x + width - 60, fl_y - 30 + height / 2, 60, 60);

            gr.DrawString("A", new Font("Arial", 16), Brushes.Black, fl_x, fl_y + (height / 3) - fl_lengtha - 20);
            gr.DrawString("B", new Font("Arial", 16), Brushes.Black, fl_x, fl_y + ((2 * height) / 3) - fl_lengtha - 20);
            gr.DrawString(Encoding.UTF8.GetString(Encoding.Convert(Encoding.Unicode, Encoding.UTF8, Encoding.Unicode.GetBytes("\u2265")))+"1", new Font("Arial", 40), Brushes.Black, fl_x - 50 + width / 2, fl_y - 50 + height / 2);
        }
        void draw_equal(double x, double y,double col)
        {
            float width = pictureBox1.Width/(float)col, height = pictureBox1.Height/ (float)col;
            gr = pictureBox1.CreateGraphics();
            float fl_lengtha = (float)lengtha;
            float fl_x = (float)x; float fl_y = (float)y;
            gr.FillRectangle(Brushes.White, fl_x, fl_y + (height / 3) - fl_lengtha, 2 * fl_lengtha, 2 * fl_lengtha);
            gr.FillRectangle(Brushes.White, fl_x, fl_y + ((2 * height) / 3) - fl_lengtha, 2 * fl_lengtha, 2 * fl_lengtha);

            gr.DrawRectangle(Pens.Black, fl_x, fl_y + (height / 3) - fl_lengtha, 2 * fl_lengtha, 2 * fl_lengtha);
            gr.DrawRectangle(Pens.Black, fl_x, fl_y + ((2 * height) / 3) - fl_lengtha, 2 * fl_lengtha, 2 * fl_lengtha);
            gr.DrawLine(Pens.Black, fl_x + fl_lengtha, fl_y + (height / 3), fl_x + width / 4, fl_y + (height / 3));
            gr.DrawLine(Pens.Black, fl_x + fl_lengtha, fl_y + ((2 * height) / 3), fl_x + width / 4, fl_y + ((2 * height) / 3));
            gr.DrawRectangle(Pens.Black, fl_x + (width / 4), fl_y + fl_lengtha, width / 2, height - 2 * fl_lengtha);
            gr.DrawLine(Pens.Black, fl_x + (width * 3) / 4, fl_y + height / 2, fl_x + width - 30, fl_y + height / 2);

            gr.FillRectangle(Brushes.White, fl_x + width - 60, fl_y - 30 + height / 2, 60, 60);
            gr.DrawRectangle(Pens.Black, fl_x + width - 60, fl_y - 30 + height / 2, 60, 60);

            gr.DrawString("A", new Font("Arial", 16), Brushes.Black, fl_x, fl_y + (height / 3) - fl_lengtha - 20);
            gr.DrawString("B", new Font("Arial", 16), Brushes.Black, fl_x, fl_y + ((2 * height) / 3) - fl_lengtha - 20);
            gr.DrawString(Encoding.UTF8.GetString(Encoding.Convert(Encoding.Unicode, Encoding.UTF8, Encoding.Unicode.GetBytes("\u2265"))), new Font("Arial", 40), Brushes.Black, fl_x - 50 + width / 2, fl_y - 50 + height / 2);
        }
        void draw_disagr(double x, double y,double col)
        {
            float width = pictureBox1.Width/ (float)col, height = pictureBox1.Height / (float)col;
            gr = pictureBox1.CreateGraphics();
            float fl_lengtha = (float)lengtha;
            float fl_x = (float)x; float fl_y = (float)y;
           
            gr.DrawLine(Pens.Black, fl_x + fl_lengtha, fl_y + (height / 2), fl_x + width / 4, fl_y + (height / 2));
            gr.DrawRectangle(Pens.Black, fl_x + (width / 4), fl_y + fl_lengtha, width / 2, height - 2 * fl_lengtha);
            gr.DrawLine(Pens.Black, fl_x + (width * 3) / 4, fl_y + height / 2, fl_x + width - 30, fl_y + height / 2);

            gr.FillEllipse(Brushes.White, fl_x + width / 4 - (fl_lengtha / 2), fl_y + (height / 2) - (fl_lengtha / 2), fl_lengtha, fl_lengtha);
            gr.DrawEllipse(Pens.Black, fl_x + width / 4 - (fl_lengtha / 2), fl_y + (height / 2) - (fl_lengtha / 2), fl_lengtha, fl_lengtha);

            gr.FillRectangle(Brushes.White, fl_x, fl_y + (height / 2) - fl_lengtha, 2 * fl_lengtha, 2 * fl_lengtha);
            gr.DrawRectangle(Pens.Black, fl_x, fl_y + (height / 2) - fl_lengtha, 2 * fl_lengtha, 2 * fl_lengtha);  

            gr.FillRectangle(Brushes.White, fl_x + width - 60, fl_y - 30 + height / 2, 60, 60);
            gr.DrawRectangle(Pens.Black, fl_x + width - 60, fl_y - 30 + height / 2, 60, 60);

            gr.DrawString("A", new Font("Arial", 16), Brushes.Black, fl_x, fl_y + (height / 2) - fl_lengtha - 20);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            gr = pictureBox1.CreateGraphics();
            gr.Clear(Color.White);
            x = 0; double col = 1;
            y = 0;
            float fl_x = (float)x; float fl_y = (float)y; float fl_lengtha = (float)lengtha;
            float width = pictureBox1.Width / (float)col, height = pictureBox1.Height / (float)col;
            gr.DrawString("A", new Font("Arial", 16), Brushes.Black, fl_x, fl_y + (height / 3) - fl_lengtha - 20);
            gr.DrawString("B", new Font("Arial", 16), Brushes.Black, fl_x, fl_y + ((2 * height) / 3) - fl_lengtha - 20);
            draw_disun(x, y,1);
            func = "disun";
            label1.Text = "A" + Encoding.UTF8.GetString(Encoding.Convert(Encoding.Unicode, Encoding.UTF8, Encoding.Unicode.GetBytes("\u2228"))) + "B";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gr = pictureBox1.CreateGraphics();
            gr.Clear(Color.White);
            x = 0; double col = 1;
            y = 0;
            float fl_x = (float)x; float fl_y = (float)y; float fl_lengtha = (float)lengtha;
            float width = pictureBox1.Width / (float)col, height = pictureBox1.Height / (float)col;
            gr.DrawString("A", new Font("Arial", 16), Brushes.Black, fl_x, fl_y + (height / 3) - fl_lengtha - 20);
            gr.DrawString("B", new Font("Arial", 16), Brushes.Black, fl_x, fl_y + ((2 * height) / 3) - fl_lengtha - 20);
            draw_impl(x, y,col);
            func = "impl";
            label1.Text = "A" + Encoding.UTF8.GetString(Encoding.Convert(Encoding.Unicode, Encoding.UTF8, Encoding.Unicode.GetBytes("\u21D2"))) + "B";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gr = pictureBox1.CreateGraphics();
            gr.Clear(Color.White);
            x = 0; double col = 1;
            y = 0;
            float fl_x = (float)x; float fl_y = (float)y; float fl_lengtha = (float)lengtha;
            float width = pictureBox1.Width / (float)col, height = pictureBox1.Height / (float)col;
          
            draw_disagr(x, y,col);
            func = "disagr";
            label1.Text = Encoding.UTF8.GetString(Encoding.Convert(Encoding.Unicode, Encoding.UTF8, Encoding.Unicode.GetBytes("\u00AC")))+"A";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            gr = pictureBox1.CreateGraphics();
            gr.Clear(Color.White);
            x = 0; double col = 2;
            y = 0;
            float fl_x = (float)x; float fl_y = (float)y; float fl_lengtha = (float)lengtha;
            float width = pictureBox1.Width / (float)col, height = pictureBox1.Height / (float)col;
            gr.DrawString("A", new Font("Arial", 16), Brushes.Black, fl_x, fl_y + (height / 3) - fl_lengtha - 20);
            gr.DrawString("B", new Font("Arial", 16), Brushes.Black, fl_x, fl_y + ((2 * height) / 3) - fl_lengtha - 20);
            draw_conun(x, y,col);
            draw_not_conun(x, y + pictureBox1.Height/2, 2);
            draw_connected_disun(x+pictureBox1.Width/2,y+pictureBox1.Height/4,2);
            func = "equal";
            label1.Text = "A↔B";
        }

        string func = "";
        private void button1_Click(object sender, EventArgs e)
        {
            gr = pictureBox1.CreateGraphics();
            gr.Clear(Color.White);
            x = 0;double col = 1;
            y = 0;
            float fl_x = (float)x; float fl_y = (float)y; float fl_lengtha = (float)lengtha;
            float width = pictureBox1.Width / (float)col, height = pictureBox1.Height / (float)col;            
            gr.DrawString("A", new Font("Arial", 16), Brushes.Black, fl_x, fl_y + (height / 3) - fl_lengtha - 20);
            gr.DrawString("B", new Font("Arial", 16), Brushes.Black, fl_x, fl_y + ((2 * height) / 3) - fl_lengtha - 20);
            label1.Text="A"+ Encoding.UTF8.GetString(Encoding.Convert(Encoding.Unicode, Encoding.UTF8, Encoding.Unicode.GetBytes("\u2227")))+"B";
            func = "conun";
            draw_conun(x, y, col);
        }


        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            gr = pictureBox1.CreateGraphics();
            float col;
            float width, height;           
            float fl_x = (float)x; float fl_y = (float)y; float fl_lengtha = (float)lengtha;
           
            if (func=="conun")
            {
                //a
                col = 1;
                width = pictureBox1.Width / col; height = pictureBox1.Height / col;
                if ((e.X>=x&&e.Y>= y + (height / 3) - fl_lengtha) &&(e.X<=x+2* fl_lengtha && e.Y<= y + (height / 3) + 2*fl_lengtha) &&a==false)
            {
                gr.FillRectangle(Brushes.Yellow, fl_x, fl_y + (height / 3) - fl_lengtha, 2* fl_lengtha, 2* fl_lengtha);
                gr.DrawRectangle(Pens.Black, fl_x, fl_y + (height / 3) - fl_lengtha, 2 * fl_lengtha, 2 * fl_lengtha);
                gr.FillRectangle(Brushes.White, fl_x, fl_y + (height / 3) - fl_lengtha - 16, 50, 16);                
                gr.DrawString("A=1", new Font("Arial", 16), Brushes.Black, fl_x, fl_y + (height / 3) - fl_lengtha - 20);
                a = true;
            }
            else if ((e.X >= x && e.Y >= y + (height / 3) - fl_lengtha) && (e.X <= x + 2* fl_lengtha && e.Y <= y + (height / 3) + fl_lengtha) && a == true)
            {
                gr.FillRectangle(Brushes.White, fl_x, fl_y + (height / 3) - fl_lengtha, 2* fl_lengtha, 2* fl_lengtha);
                gr.DrawRectangle(Pens.Black, fl_x, fl_y + (height / 3) - fl_lengtha, 2* fl_lengtha, 2* fl_lengtha);
                gr.FillRectangle(Brushes.White, fl_x, fl_y + (height / 3) - fl_lengtha -16, 50, 16);
                gr.DrawString("A=0", new Font("Arial", 16), Brushes.Black, fl_x, fl_y + (height / 3) - fl_lengtha - 20);
                a = false;
            }

            //b

            if ((e.X >= x && e.Y >= y + 2*(height / 3) - fl_lengtha) && (e.X <= x + 2 * fl_lengtha && e.Y <= y + (2*(height / 3)) + 2 * fl_lengtha) && b == false)
            {
                gr.FillRectangle(Brushes.Yellow, fl_x, fl_y + ((2*height) / 3) - fl_lengtha, 2 * fl_lengtha, 2 * fl_lengtha);
                gr.DrawRectangle(Pens.Black, fl_x, fl_y + ((2 * height) / 3) - fl_lengtha, 2 * fl_lengtha, 2 * fl_lengtha);
                gr.FillRectangle(Brushes.White, fl_x, fl_y + (2*height / 3) - fl_lengtha - 16, 50, 16);
                gr.DrawString("B=1", new Font("Arial", 16), Brushes.Black, fl_x, fl_y + ((2 * height) / 3) - fl_lengtha - 20);   
                b = true;
            }
            else if ((e.X >= x && e.Y >= y + ((2*height) / 3) - fl_lengtha) && (e.X <= x + 2 * fl_lengtha && e.Y <= y + ((2*height) / 3) + fl_lengtha) && b == true)
            {
                gr.FillRectangle(Brushes.White, fl_x, fl_y + ((2*height) / 3) - fl_lengtha, 2 * fl_lengtha, 2 * fl_lengtha);
                gr.DrawRectangle(Pens.Black, fl_x, fl_y + ((2*height) / 3) - fl_lengtha, 2 * fl_lengtha, 2 * fl_lengtha);
                gr.FillRectangle(Brushes.White, fl_x, fl_y + (2*height / 3) - fl_lengtha - 16, 50, 16);
                gr.DrawString("B=0", new Font("Arial", 16), Brushes.Black, fl_x, fl_y + ((2 * height) / 3) - fl_lengtha - 20);
                b = false;
            }
            
            //res

            if (a&&b==true)
            {
                res = true;
            }
            else
            {
                res = false;
            }

            if (res==true)
            {
                gr.FillRectangle(Brushes.Red, fl_x + width - 60, fl_y - 30 + height / 2, 60, 60);
                gr.DrawRectangle(Pens.Black, fl_x + width - 60, fl_y - 30 + height / 2, 60, 60);
                gr.FillRectangle(Brushes.White, fl_x + width - 40, fl_y - 70 + height / 2, 20, 30);
                gr.DrawString("1", new Font("Arial", 20), Brushes.Red, fl_x + width - 40, fl_y - 70 + height / 2);
            }
            else
            {
                gr.FillRectangle(Brushes.White, fl_x + width - 60, fl_y - 30 + height / 2, 60, 60);
                gr.DrawRectangle(Pens.Black, fl_x + width - 60, fl_y - 30 + height / 2, 60, 60);
                gr.FillRectangle(Brushes.White, fl_x + width - 40, fl_y - 70 + height / 2, 20, 30);
                gr.DrawString("0", new Font("Arial", 20), Brushes.Black, fl_x + width - 40, fl_y - 70 + height / 2);
            }
            }
            else if(func=="disun")
            {
                //a
                col = 1;
                width = pictureBox1.Width / col; height = pictureBox1.Height / col;
                if ((e.X >= x && e.Y >= y + (height / 3) - fl_lengtha) && (e.X <= x + 2 * fl_lengtha && e.Y <= y + (height / 3) + 2 * fl_lengtha) && a == false)
                {
                    gr.FillRectangle(Brushes.Yellow, fl_x, fl_y + (height / 3) - fl_lengtha, 2 * fl_lengtha, 2 * fl_lengtha);
                    gr.DrawRectangle(Pens.Black, fl_x, fl_y + (height / 3) - fl_lengtha, 2 * fl_lengtha, 2 * fl_lengtha);
                    gr.FillRectangle(Brushes.White, fl_x, fl_y + (height / 3) - fl_lengtha - 16, 50, 16);
                    gr.DrawString("A=1", new Font("Arial", 16), Brushes.Black, fl_x, fl_y + (height / 3) - fl_lengtha - 20);
                    a = true;
                }
                else if ((e.X >= x && e.Y >= y + (height / 3) - fl_lengtha) && (e.X <= x + 2 * fl_lengtha && e.Y <= y + (height / 3) + fl_lengtha) && a == true)
                {
                    gr.FillRectangle(Brushes.White, fl_x, fl_y + (height / 3) - fl_lengtha, 2 * fl_lengtha, 2 * fl_lengtha);
                    gr.DrawRectangle(Pens.Black, fl_x, fl_y + (height / 3) - fl_lengtha, 2 * fl_lengtha, 2 * fl_lengtha);
                    gr.FillRectangle(Brushes.White, fl_x, fl_y + (height / 3) - fl_lengtha - 16, 50, 16);
                    gr.DrawString("A=0", new Font("Arial", 16), Brushes.Black, fl_x, fl_y + (height / 3) - fl_lengtha - 20);
                    a = false;
                }

                //b

                if ((e.X >= x && e.Y >= y + 2 * (height / 3) - fl_lengtha) && (e.X <= x + 2 * fl_lengtha && e.Y <= y + (2 * (height / 3)) + 2 * fl_lengtha) && b == false)
                {
                    gr.FillRectangle(Brushes.Yellow, fl_x, fl_y + ((2 * height) / 3) - fl_lengtha, 2 * fl_lengtha, 2 * fl_lengtha);
                    gr.DrawRectangle(Pens.Black, fl_x, fl_y + ((2 * height) / 3) - fl_lengtha, 2 * fl_lengtha, 2 * fl_lengtha);
                    gr.FillRectangle(Brushes.White, fl_x, fl_y + (2 * height / 3) - fl_lengtha - 16, 50, 16);
                    gr.DrawString("B=1", new Font("Arial", 16), Brushes.Black, fl_x, fl_y + ((2 * height) / 3) - fl_lengtha - 20);
                    b = true;
                }
                else if ((e.X >= x && e.Y >= y + ((2 * height) / 3) - fl_lengtha) && (e.X <= x + 2 * fl_lengtha && e.Y <= y + ((2 * height) / 3) + fl_lengtha) && b == true)
                {
                    gr.FillRectangle(Brushes.White, fl_x, fl_y + ((2 * height) / 3) - fl_lengtha, 2 * fl_lengtha, 2 * fl_lengtha);
                    gr.DrawRectangle(Pens.Black, fl_x, fl_y + ((2 * height) / 3) - fl_lengtha, 2 * fl_lengtha, 2 * fl_lengtha);
                    gr.FillRectangle(Brushes.White, fl_x, fl_y + (2 * height / 3) - fl_lengtha - 16, 50, 16);
                    gr.DrawString("B=0", new Font("Arial", 16), Brushes.Black, fl_x, fl_y + ((2 * height) / 3) - fl_lengtha - 20);
                    b = false;
                }

                //res

                if (a || b == true)
                {
                    res = true;
                }
                else
                {
                    res = false;
                }

                if (res == true)
                {
                    gr.FillRectangle(Brushes.Red, fl_x + width - 60, fl_y - 30 + height / 2, 60, 60);
                    gr.DrawRectangle(Pens.Black, fl_x + width - 60, fl_y - 30 + height / 2, 60, 60);
                    gr.FillRectangle(Brushes.White, fl_x + width - 40, fl_y - 70 + height / 2, 20, 30);
                    gr.DrawString("1", new Font("Arial", 20), Brushes.Red, fl_x + width - 40, fl_y - 70 + height / 2);
                }
                else
                {
                    gr.FillRectangle(Brushes.White, fl_x + width - 60, fl_y - 30 + height / 2, 60, 60);
                    gr.DrawRectangle(Pens.Black, fl_x + width - 60, fl_y - 30 + height / 2, 60, 60);
                    gr.FillRectangle(Brushes.White, fl_x + width - 40, fl_y - 70 + height / 2, 20, 30);
                    gr.DrawString("0", new Font("Arial", 20), Brushes.Black, fl_x + width - 40, fl_y - 70 + height / 2);
                }
            }
            else if (func=="impl")
            {
                //a
                bool nota;
                col = 1;
                width = pictureBox1.Width / col; height = pictureBox1.Height / col;
                if ((e.X >= x && e.Y >= y + (height / 3) - fl_lengtha) && (e.X <= x + 2 * fl_lengtha && e.Y <= y + (height / 3) + 2 * fl_lengtha) && a == false)
                {
                    gr.FillRectangle(Brushes.Yellow, fl_x, fl_y + (height / 3) - fl_lengtha, 2 * fl_lengtha, 2 * fl_lengtha);
                    gr.DrawRectangle(Pens.Black, fl_x, fl_y + (height / 3) - fl_lengtha, 2 * fl_lengtha, 2 * fl_lengtha);
                    gr.FillRectangle(Brushes.White, fl_x, fl_y + (height / 3) - fl_lengtha - 16, 50, 16);
                    gr.DrawString("A=1", new Font("Arial", 16), Brushes.Black, fl_x, fl_y + (height / 3) - fl_lengtha - 20);
                    a = true;
                }
                else if ((e.X >= x && e.Y >= y + (height / 3) - fl_lengtha) && (e.X <= x + 2 * fl_lengtha && e.Y <= y + (height / 3) + fl_lengtha) && a == true)
                {
                    gr.FillRectangle(Brushes.White, fl_x, fl_y + (height / 3) - fl_lengtha, 2 * fl_lengtha, 2 * fl_lengtha);
                    gr.DrawRectangle(Pens.Black, fl_x, fl_y + (height / 3) - fl_lengtha, 2 * fl_lengtha, 2 * fl_lengtha);
                    gr.FillRectangle(Brushes.White, fl_x, fl_y + (height / 3) - fl_lengtha - 16, 50, 16);
                    gr.DrawString("A=0", new Font("Arial", 16), Brushes.Black, fl_x, fl_y + (height / 3) - fl_lengtha - 20);
                    a = false;
                }
                if (a == true)
                {
                    nota = false;
                }
                else
                {
                    nota = true;
                }
                //b

                if ((e.X >= x && e.Y >= y + 2 * (height / 3) - fl_lengtha) && (e.X <= x + 2 * fl_lengtha && e.Y <= y + (2 * (height / 3)) + 2 * fl_lengtha) && b == false)
                {
                    gr.FillRectangle(Brushes.Yellow, fl_x, fl_y + ((2 * height) / 3) - fl_lengtha, 2 * fl_lengtha, 2 * fl_lengtha);
                    gr.DrawRectangle(Pens.Black, fl_x, fl_y + ((2 * height) / 3) - fl_lengtha, 2 * fl_lengtha, 2 * fl_lengtha);
                    gr.FillRectangle(Brushes.White, fl_x, fl_y + (2 * height / 3) - fl_lengtha - 16, 50, 16);
                    gr.DrawString("B=1", new Font("Arial", 16), Brushes.Black, fl_x, fl_y + ((2 * height) / 3) - fl_lengtha - 20);
                    b = true;
                }
                else if ((e.X >= x && e.Y >= y + ((2 * height) / 3) - fl_lengtha) && (e.X <= x + 2 * fl_lengtha && e.Y <= y + ((2 * height) / 3) + fl_lengtha) && b == true)
                {
                    gr.FillRectangle(Brushes.White, fl_x, fl_y + ((2 * height) / 3) - fl_lengtha, 2 * fl_lengtha, 2 * fl_lengtha);
                    gr.DrawRectangle(Pens.Black, fl_x, fl_y + ((2 * height) / 3) - fl_lengtha, 2 * fl_lengtha, 2 * fl_lengtha);
                    gr.FillRectangle(Brushes.White, fl_x, fl_y + (2 * height / 3) - fl_lengtha - 16, 50, 16);
                    gr.DrawString("B=0", new Font("Arial", 16), Brushes.Black, fl_x, fl_y + ((2 * height) / 3) - fl_lengtha - 20);
                    b = false;
                }

                //nota
                if (nota==true)
                {
                    gr.FillEllipse(Brushes.Yellow, fl_x + width / 4 - (fl_lengtha / 2), fl_y + (height / 3) - (fl_lengtha / 2), fl_lengtha, fl_lengtha);
                    gr.DrawEllipse(Pens.Black, fl_x + width / 4 - (fl_lengtha / 2), fl_y + (height / 3) - (fl_lengtha / 2), fl_lengtha, fl_lengtha);
                }
                else
                {
                    gr.FillEllipse(Brushes.White, fl_x + width / 4 - (fl_lengtha / 2), fl_y + (height / 3) - (fl_lengtha / 2), fl_lengtha, fl_lengtha);
                    gr.DrawEllipse(Pens.Black, fl_x + width / 4 - (fl_lengtha / 2), fl_y + (height / 3) - (fl_lengtha / 2), fl_lengtha, fl_lengtha);
                }
                         
                //res

                if (nota || b == true)
                {
                    res = true;
                }
                else
                {
                    res = false;
                }

                if (res == true)
                {
                    gr.FillRectangle(Brushes.Red, fl_x + width - 60, fl_y - 30 + height / 2, 60, 60);
                    gr.DrawRectangle(Pens.Black, fl_x + width - 60, fl_y - 30 + height / 2, 60, 60);
                    gr.FillRectangle(Brushes.White, fl_x + width - 40, fl_y - 70 + height / 2, 20, 30);
                    gr.DrawString("1", new Font("Arial", 20), Brushes.Red, fl_x + width - 40, fl_y - 70 + height / 2);
                }
                else
                {
                    gr.FillRectangle(Brushes.White, fl_x + width - 60, fl_y - 30 + height / 2, 60, 60);
                    gr.DrawRectangle(Pens.Black, fl_x + width - 60, fl_y - 30 + height / 2, 60, 60);
                    gr.FillRectangle(Brushes.White, fl_x + width - 40, fl_y - 70 + height / 2, 20, 30);
                    gr.DrawString("0", new Font("Arial", 20), Brushes.Black, fl_x + width - 40, fl_y - 70 + height / 2);
                }
            }
            else if(func=="disagr")
            {
                col = 1;
                width = pictureBox1.Width / col; height = pictureBox1.Height / col;
                if ((e.X >= x && e.Y >= y + (height / 2) - fl_lengtha) && (e.X <= x + 2 * fl_lengtha && e.Y <= y + (height / 2) + 2 * fl_lengtha) && a == false)
                {
                    gr.FillRectangle(Brushes.Yellow, fl_x, fl_y + (height / 2) - fl_lengtha, 2 * fl_lengtha, 2 * fl_lengtha);
                    gr.DrawRectangle(Pens.Black, fl_x, fl_y + (height / 2) - fl_lengtha, 2 * fl_lengtha, 2 * fl_lengtha);
                    gr.FillRectangle(Brushes.White, fl_x, fl_y + (height / 2) - fl_lengtha - 16, 50, 16);
                    gr.DrawString("A=1", new Font("Arial", 16), Brushes.Black, fl_x, fl_y + (height / 2) - fl_lengtha - 20);
                    a = true;
                }
                else if ((e.X >= x && e.Y >= y + (height / 2) - fl_lengtha) && (e.X <= x + 2 * fl_lengtha && e.Y <= y + (height / 2) + fl_lengtha) && a == true)
                {
                    gr.FillRectangle(Brushes.White, fl_x, fl_y + (height / 2) - fl_lengtha, 2 * fl_lengtha, 2 * fl_lengtha);
                    gr.DrawRectangle(Pens.Black, fl_x, fl_y + (height / 2) - fl_lengtha, 2 * fl_lengtha, 2 * fl_lengtha);
                    gr.FillRectangle(Brushes.White, fl_x, fl_y + (height / 2) - fl_lengtha - 16, 50, 16);
                    gr.DrawString("A=0", new Font("Arial", 16), Brushes.Black, fl_x, fl_y + (height / 2) - fl_lengtha - 20);
                    a = false;
                }
                bool nota;
                if (a == true)
                {
                    nota = false;
                }
                else
                {
                    nota = true;
                }

                if (nota == true)
                {
                    gr.FillEllipse(Brushes.Yellow, fl_x + width / 4 - (fl_lengtha / 2), fl_y + (height / 2) - (fl_lengtha / 2), fl_lengtha, fl_lengtha);
                    gr.DrawEllipse(Pens.Black, fl_x + width / 4 - (fl_lengtha / 2), fl_y + (height / 2) - (fl_lengtha / 2), fl_lengtha, fl_lengtha);
                }
                else
                {
                    gr.FillEllipse(Brushes.White, fl_x + width / 4 - (fl_lengtha / 2), fl_y + (height / 2) - (fl_lengtha / 2), fl_lengtha, fl_lengtha);
                    gr.DrawEllipse(Pens.Black, fl_x + width / 4 - (fl_lengtha / 2), fl_y + (height / 2) - (fl_lengtha / 2), fl_lengtha, fl_lengtha);
                }
                res = nota;
                if (res == true)
                {
                    gr.FillRectangle(Brushes.Red, fl_x + width - 60, fl_y - 30 + height / 2, 60, 60);
                    gr.DrawRectangle(Pens.Black, fl_x + width - 60, fl_y - 30 + height / 2, 60, 60);
                    gr.FillRectangle(Brushes.White, fl_x + width - 40, fl_y - 70 + height / 2, 20, 30);
                    gr.DrawString("1", new Font("Arial", 20), Brushes.Red, fl_x + width - 40, fl_y - 70 + height / 2);
                }
                else
                {
                    gr.FillRectangle(Brushes.White, fl_x + width - 60, fl_y - 30 + height / 2, 60, 60);
                    gr.DrawRectangle(Pens.Black, fl_x + width - 60, fl_y - 30 + height / 2, 60, 60);
                    gr.FillRectangle(Brushes.White, fl_x + width - 40, fl_y - 70 + height / 2, 20, 30);
                    gr.DrawString("0", new Font("Arial", 20), Brushes.Black, fl_x + width - 40, fl_y - 70 + height / 2);
                }
            }
            else if (func == "equal")
            {
                //a
                bool nota,notb;
                col = 2;
                width = pictureBox1.Width / col; height = pictureBox1.Height / col;
                if ((e.X >= x && e.Y >= y + (height / 3) - fl_lengtha) && (e.X <= x + 2 * fl_lengtha && e.Y <= y + (height / 3) + 2 * fl_lengtha) && a == false)
                {
                    gr.FillRectangle(Brushes.Yellow, fl_x, fl_y + (height / 3) - fl_lengtha, 2 * fl_lengtha, 2 * fl_lengtha);
                    gr.DrawRectangle(Pens.Black, fl_x, fl_y + (height / 3) - fl_lengtha, 2 * fl_lengtha, 2 * fl_lengtha);

                    gr.FillRectangle(Brushes.Yellow, fl_x, fl_y + height+(height / 3) - fl_lengtha, 2 * fl_lengtha, 2 * fl_lengtha);
                    gr.DrawRectangle(Pens.Black, fl_x, fl_y + height + (height / 3) - fl_lengtha, 2 * fl_lengtha, 2 * fl_lengtha);

                    gr.FillRectangle(Brushes.White, fl_x, fl_y + (height / 3) - fl_lengtha - 16, 50, 16);
                    gr.DrawString("A=1", new Font("Arial", 16), Brushes.Black, fl_x, fl_y + (height / 3) - fl_lengtha - 20);
                    a = true;
                }
                else if ((e.X >= x && e.Y >= y + (height / 3) - fl_lengtha) && (e.X <= x + 2 * fl_lengtha && e.Y <= y + (height / 3) + fl_lengtha) && a == true)
                {
                    gr.FillRectangle(Brushes.White, fl_x, fl_y + (height / 3) - fl_lengtha, 2 * fl_lengtha, 2 * fl_lengtha);
                    gr.DrawRectangle(Pens.Black, fl_x, fl_y + (height / 3) - fl_lengtha, 2 * fl_lengtha, 2 * fl_lengtha);

                    gr.FillRectangle(Brushes.White, fl_x, fl_y + height + (height / 3) - fl_lengtha, 2 * fl_lengtha, 2 * fl_lengtha);
                    gr.DrawRectangle(Pens.Black, fl_x, fl_y + height + (height / 3) - fl_lengtha, 2 * fl_lengtha, 2 * fl_lengtha);

                    gr.FillRectangle(Brushes.White, fl_x, fl_y + (height / 3) - fl_lengtha - 16, 50, 16);
                    gr.DrawString("A=0", new Font("Arial", 16), Brushes.Black, fl_x, fl_y + (height / 3) - fl_lengtha - 20);
                    a = false;
                }
                if (a == true)
                {
                    nota = false;
                }
                else
                {
                    nota = true;
                }
                if (b == true)
                {
                    notb = false;
                }
                else
                {
                    notb = true;
                }
                //b

                if ((e.X >= x && e.Y >= y + 2 * (height / 3) - fl_lengtha) && (e.X <= x + 2 * fl_lengtha && e.Y <= y + (2 * (height / 3)) + 2 * fl_lengtha) && b == false)
                {
                    gr.FillRectangle(Brushes.Yellow, fl_x, fl_y + ((2 * height) / 3) - fl_lengtha, 2 * fl_lengtha, 2 * fl_lengtha);
                    gr.DrawRectangle(Pens.Black, fl_x, fl_y + ((2 * height) / 3) - fl_lengtha, 2 * fl_lengtha, 2 * fl_lengtha);

                    gr.FillRectangle(Brushes.Yellow, fl_x, fl_y + height+((2 * height) / 3) - fl_lengtha, 2 * fl_lengtha, 2 * fl_lengtha);
                    gr.DrawRectangle(Pens.Black, fl_x, fl_y + height+((2 * height) / 3) - fl_lengtha, 2 * fl_lengtha, 2 * fl_lengtha);


                    gr.FillRectangle(Brushes.White, fl_x, fl_y + (2 * height / 3) - fl_lengtha - 16, 50, 16);
                    gr.DrawString("B=1", new Font("Arial", 16), Brushes.Black, fl_x, fl_y + ((2 * height) / 3) - fl_lengtha - 20);
                    b = true;
                }
                else if ((e.X >= x && e.Y >= y + ((2 * height) / 3) - fl_lengtha) && (e.X <= x + 2 * fl_lengtha && e.Y <= y + ((2 * height) / 3) + fl_lengtha) && b == true)
                {
                    gr.FillRectangle(Brushes.White, fl_x, fl_y + ((2 * height) / 3) - fl_lengtha, 2 * fl_lengtha, 2 * fl_lengtha);
                    gr.DrawRectangle(Pens.Black, fl_x, fl_y + ((2 * height) / 3) - fl_lengtha, 2 * fl_lengtha, 2 * fl_lengtha);

                    gr.FillRectangle(Brushes.White, fl_x, fl_y + height+((2 * height) / 3) - fl_lengtha, 2 * fl_lengtha, 2 * fl_lengtha);
                    gr.DrawRectangle(Pens.Black, fl_x, fl_y + height +((2 * height) / 3) - fl_lengtha, 2 * fl_lengtha, 2 * fl_lengtha);


                    gr.FillRectangle(Brushes.White, fl_x, fl_y + (2 * height / 3) - fl_lengtha - 16, 50, 16);
                    gr.DrawString("B=0", new Font("Arial", 16), Brushes.Black, fl_x, fl_y + ((2 * height) / 3) - fl_lengtha - 20);
                    b = false;
                }

                //nota
                if (nota == true)
                {
                    gr.FillEllipse(Brushes.Yellow, fl_x + width / 4 - (fl_lengtha / 2), fl_y + height+(height / 3) - (fl_lengtha / 2), fl_lengtha, fl_lengtha);
                    gr.DrawEllipse(Pens.Black, fl_x + width / 4 - (fl_lengtha / 2), fl_y + height+(height / 3) - (fl_lengtha / 2), fl_lengtha, fl_lengtha);
                }
                else
                {
                    gr.FillEllipse(Brushes.White, fl_x + width / 4 - (fl_lengtha / 2), fl_y + height + (height / 3) - (fl_lengtha / 2), fl_lengtha, fl_lengtha);
                    gr.DrawEllipse(Pens.Black, fl_x + width / 4 - (fl_lengtha / 2), fl_y + height + (height / 3) - (fl_lengtha / 2), fl_lengtha, fl_lengtha);
                }
                //notb
                if (notb == true)
                {
                    gr.FillEllipse(Brushes.Yellow, fl_x + width / 4 - (fl_lengtha / 2), fl_y + height+(2*height / 3) - (fl_lengtha / 2), fl_lengtha, fl_lengtha);
                    gr.DrawEllipse(Pens.Black, fl_x + width / 4 - (fl_lengtha / 2), fl_y + height+(2*height / 3) - (fl_lengtha / 2), fl_lengtha, fl_lengtha);
                }
                else
                {
                    gr.FillEllipse(Brushes.White, fl_x + width / 4 - (fl_lengtha / 2), fl_y + height + (2 * height / 3) - (fl_lengtha / 2), fl_lengtha, fl_lengtha);
                    gr.DrawEllipse(Pens.Black, fl_x + width / 4 - (fl_lengtha / 2), fl_y + height + (2 * height / 3) - (fl_lengtha / 2), fl_lengtha, fl_lengtha);
                }
                //res
                bool res1=false,res2=false;
                
                if (a && b == true)
                {
                    res1 = true;
                }
                else
                {
                    res1 = false;
                }

                if (nota && notb == true)
                {
                    res2 = true;
                }
                else
                {
                    res2 = false;
                }

                if (res1 == true)
                {
                    gr.FillRectangle(Brushes.Red, fl_x + width - 60, fl_y - 30 + height / 2, 60, 60);
                    gr.DrawRectangle(Pens.Black, fl_x + width - 60, fl_y - 30 + height / 2, 60, 60);
                    gr.FillRectangle(Brushes.White, fl_x + width - 40, fl_y - 70 + height / 2, 20, 30);
                    gr.DrawString("1", new Font("Arial", 20), Brushes.Red, fl_x + width - 40, fl_y - 70 + height / 2);
                }
                else
                {
                    gr.FillRectangle(Brushes.White, fl_x + width - 60, fl_y - 30 + height / 2, 60, 60);
                    gr.DrawRectangle(Pens.Black, fl_x + width - 60, fl_y - 30 + height / 2, 60, 60);
                    gr.FillRectangle(Brushes.White, fl_x + width - 40, fl_y - 70 + height / 2, 20, 30);
                    gr.DrawString("0", new Font("Arial", 20), Brushes.Black, fl_x + width - 40, fl_y - 70 + height / 2);
                }
                if (res2 == true)
                {
                    gr.FillRectangle(Brushes.Red, fl_x + width - 60, fl_y - 30 +height+ height / 2, 60, 60);
                    gr.DrawRectangle(Pens.Black, fl_x + width - 60, fl_y - 30 + height+height / 2, 60, 60);
                    gr.FillRectangle(Brushes.White, fl_x + width - 40, fl_y - 70 +height+ height / 2, 20, 30);
                    gr.DrawString("1", new Font("Arial", 20), Brushes.Red, fl_x + width - 40, fl_y - 70 +height+ height / 2);
                }
                else
                {
                    gr.FillRectangle(Brushes.White, fl_x + width - 60, fl_y - 30 +height+ height / 2, 60, 60);
                    gr.DrawRectangle(Pens.Black, fl_x + width - 60, fl_y - 30 + height+height / 2, 60, 60);
                    gr.FillRectangle(Brushes.White, fl_x + width - 40, fl_y - 70 +height+ height / 2, 20, 30);
                    gr.DrawString("0", new Font("Arial", 20), Brushes.Black, fl_x + width - 40, fl_y - 70 + height+height / 2);
                }

                if (res1||res2==true)
                {
                    res = true;
                }
                else
                {
                    res = false;
                }
                if (res == true)
                {
                    gr.FillRectangle(Brushes.Red, fl_x + 2 * width - 60, fl_y - 30 +2*height / 2, 60, 60);
                    gr.DrawRectangle(Pens.Black, fl_x+ 2 * width - 60, fl_y - 30 + 2 * height / 2, 60, 60);
                    gr.FillRectangle(Brushes.White, fl_x +width+ width - 40, fl_y - 70 + 2 * height / 2, 20, 30);
                    gr.DrawString("1", new Font("Arial", 20), Brushes.Red, fl_x +width+ width - 40, fl_y - 70 + 2 * height / 2);
                }
                else
                {
                    gr.FillRectangle(Brushes.White, fl_x + 2*width - 60, fl_y - 30 + 2 * height / 2, 60, 60);
                    gr.DrawRectangle(Pens.Black, fl_x + 2 * width - 60, fl_y - 30 + 2 * height / 2, 60, 60);
                    gr.FillRectangle(Brushes.White, fl_x + width + width - 40, fl_y - 70 + 2 * height / 2, 20, 30);
                    gr.DrawString("0", new Font("Arial", 20), Brushes.Black, fl_x + 2 * width - 40, fl_y - 70 + 2 * height / 2);
                }
            }

        }

        private void Elektroschemes_Load(object sender, EventArgs e)
        {
            button1.Text = Encoding.UTF8.GetString(Encoding.Convert(Encoding.Unicode, Encoding.UTF8, Encoding.Unicode.GetBytes("\u2227")))+ " (and)";
            button2.Text = Encoding.UTF8.GetString(Encoding.Convert(Encoding.Unicode, Encoding.UTF8, Encoding.Unicode.GetBytes("\u2228"))) + " (or)";
            button3.Text = Encoding.UTF8.GetString(Encoding.Convert(Encoding.Unicode, Encoding.UTF8, Encoding.Unicode.GetBytes("\u21D2"))) + " (if-then)";
            button4.Text = Encoding.UTF8.GetString(Encoding.Convert(Encoding.Unicode, Encoding.UTF8, Encoding.Unicode.GetBytes("\u00AC"))) + " (not)";
            button5.Text = "↔" + " (equal)";            
        }
    }
}
