using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace animasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
           



        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
             int x = pictureBox2.Location.X;
             int y = pictureBox2.Location.Y;
             x += 10;
             
            

            double orta = ortnok(pictureBox1, pictureBox4);

           if(x<=orta)
            {
                y -= 5;
                pictureBox2.Location = new Point(x, y);
            }
            else
            {
                y += 5;
                pictureBox2.Location = new Point(x, y);
            }


           pictureBox3.Left += 8;
            if (pictureBox3.Left >= 731)
                timer1.Enabled = false;


        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
        }

        private double ortnok(PictureBox p1, PictureBox p2 )
        {
            double p1x = p1.Location.X;
            double p2x = p2.Location.X;

           double ortnok=(p1x + p2x) / 2;
            return ortnok;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
