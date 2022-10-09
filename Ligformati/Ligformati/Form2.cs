using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ligformati
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Random rastgele = new Random();

        int gspuan = 0;
        int fbpuan = 0;
        int bjkpuan = 0;
        int tspuan = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            int a = rastgele.Next(0, 5);
            int b = rastgele.Next(0, 5);
            int c = rastgele.Next(0, 5);
            int d = rastgele.Next(0, 5);

            label4.Text = a.ToString();
            label5.Text = b.ToString();
            label8.Text = c.ToString();
            label6.Text = d.ToString();

            if (Convert.ToInt32(label4.Text) > Convert.ToInt32(label5.Text))
            {
                gspuan = gspuan + 3;
                labelgspuan.Text = gspuan.ToString();
            }
            if(Convert.ToInt32(label5.Text) > Convert.ToInt32(label4.Text))
            {
                fbpuan = fbpuan + 3;
                labelfbpuan.Text= fbpuan.ToString();
            }
            if (Convert.ToInt32(label5.Text) == Convert.ToInt32(label4.Text))
            {
                fbpuan = fbpuan + 1;
                gspuan = gspuan + 1;
                labelfbpuan.Text = fbpuan.ToString();
                labelgspuan.Text = gspuan.ToString();
            }
            
            
            
            if (Convert.ToInt32(label8.Text) > Convert.ToInt32(label6.Text))
            {
                bjkpuan = bjkpuan + 3;
                labelbjkpuan.Text = bjkpuan.ToString();
            }
            if (Convert.ToInt32(label6.Text) > Convert.ToInt32(label8.Text))
            {
                tspuan = tspuan + 3;
                labeltspuan.Text = tspuan.ToString();
            }
            if (Convert.ToInt32(label6.Text) == Convert.ToInt32(label8.Text))
            {
                bjkpuan = bjkpuan + 1;
                tspuan = tspuan + 1;
                labelbjkpuan.Text = bjkpuan.ToString();
                labeltspuan.Text = tspuan.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            int a = rastgele.Next(0, 5);
            int b = rastgele.Next(0, 5);
            int c = rastgele.Next(0, 5);
            int d = rastgele.Next(0, 5);

            label11.Text = a.ToString();
            label12.Text = b.ToString();
            label15.Text = c.ToString();
            label21.Text = d.ToString();
        
        
            if(Convert.ToInt32(label11.Text) > Convert.ToInt32(label12.Text))
            {
                gspuan = gspuan + 3;
                labelgspuan.Text = gspuan.ToString();
            }
            if(Convert.ToInt32(label12.Text) > Convert.ToInt32(label11.Text))
            {
                bjkpuan = bjkpuan + 3;
                labelbjkpuan.Text = bjkpuan.ToString();
            }
            if (Convert.ToInt32(label11.Text) == Convert.ToInt32(label12.Text))
            {
                bjkpuan = bjkpuan + 1;
                gspuan = gspuan + 1;
                labelbjkpuan.Text = gspuan.ToString();
                labelgspuan.Text = bjkpuan.ToString();
            }
            
            
            if (Convert.ToInt32(label15.Text) > Convert.ToInt32(label21.Text))
            {
                fbpuan = fbpuan + 3;
                labelfbpuan.Text = fbpuan.ToString();
            }
            if (Convert.ToInt32(label21.Text) > Convert.ToInt32(label15.Text))
            {
                tspuan = tspuan + 3;
                labeltspuan.Text = tspuan.ToString();
            }
            if (Convert.ToInt32(label15.Text) == Convert.ToInt32(label21.Text))
            {
                fbpuan = fbpuan + 1;
                tspuan = tspuan + 1;
                labelfbpuan.Text = fbpuan.ToString();
                labeltspuan.Text = tspuan.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            int a = rastgele.Next(0, 5);
            int b = rastgele.Next(0, 5);
            int c = rastgele.Next(0, 5);
            int d = rastgele.Next(0, 5);

            label25.Text = a.ToString();
            label26.Text = b.ToString();
            label29.Text = c.ToString();
            label31.Text = d.ToString();

            if (Convert.ToInt32(label25.Text) > Convert.ToInt32(label26.Text))
            {
                fbpuan = fbpuan + 3;
                labelfbpuan.Text = fbpuan.ToString();
          
            }
            if (Convert.ToInt32(label26.Text) > Convert.ToInt32(label25.Text))
            {
                bjkpuan = bjkpuan + 3;
                labelbjkpuan.Text = bjkpuan.ToString();
            }
            if (Convert.ToInt32(label25.Text) == Convert.ToInt32(label26.Text))
            {
                bjkpuan = bjkpuan + 1;
                fbpuan = fbpuan + 1;
                labelfbpuan.Text = fbpuan.ToString();
                labelbjkpuan.Text = bjkpuan.ToString();
            }


            if (Convert.ToInt32(label29.Text) > Convert.ToInt32(label31.Text))
            {
                tspuan = tspuan + 3;
                labeltspuan.Text = tspuan.ToString();
                
            }
            if (Convert.ToInt32(label31.Text) > Convert.ToInt32(label29.Text))
            {
                gspuan = gspuan + 3;
                labelgspuan.Text = gspuan.ToString();
            }
            if (Convert.ToInt32(label29.Text) == Convert.ToInt32(label31.Text))
            {
                tspuan = tspuan + 1;
                gspuan = gspuan + 1;
                labelgspuan.Text = gspuan.ToString();
                labeltspuan.Text = tspuan.ToString();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(labelgspuan.Text) > Convert.ToInt32(labelfbpuan.Text) && Convert.ToInt32(labelgspuan.Text) > Convert.ToInt32(labeltspuan.Text) && Convert.ToInt32(labelgspuan.Text) > Convert.ToInt32(labelbjkpuan.Text))
            {
                axWindowsMediaPlayer1.URL = "C:\\Users\\YusufSahin\\Desktop\\c.mp3";
                label35.Text = "Sampiyon Galatasaray ";
                pictureBox1.ImageLocation = "C:\\Users\\YusufSahin\\Desktop\\a";
            }
            if (Convert.ToInt32(labelfbpuan.Text) > Convert.ToInt32(labelgspuan.Text) && Convert.ToInt32(labelfbpuan.Text) > Convert.ToInt32(labeltspuan.Text) && Convert.ToInt32(labelfbpuan.Text) > Convert.ToInt32(labelbjkpuan.Text))
            {
                axWindowsMediaPlayer1.URL = "C:\\Users\\YusufSahin\\Desktop\\d.mp3";
                label35.Text = "Sampiyon Fenerbahce";
                pictureBox1.ImageLocation = "C:\\Users\\YusufSahin\\Desktop\\b";
            }
            if (Convert.ToInt32(labelbjkpuan.Text) > Convert.ToInt32(labelgspuan.Text) && Convert.ToInt32(labelbjkpuan.Text) > Convert.ToInt32(labeltspuan.Text) && Convert.ToInt32(labelbjkpuan.Text) > Convert.ToInt32(labelfbpuan.Text))
            {
                axWindowsMediaPlayer1.URL = "C:\\Users\\YusufSahin\\Desktop\\c.mp3";
                label35.Text = "Sampiyon Besiktas";
                pictureBox1.ImageLocation = "C:\\Users\\YusufSahin\\Desktop\\a";

            }
            if (Convert.ToInt32(labeltspuan.Text) > Convert.ToInt32(labelgspuan.Text) && Convert.ToInt32(labeltspuan.Text) > Convert.ToInt32(labelbjkpuan.Text) && Convert.ToInt32(labeltspuan.Text) > Convert.ToInt32(labelfbpuan.Text))
            {
                axWindowsMediaPlayer1.URL = "C:\\Users\\YusufSahin\\Desktop\\d.mp3";
                label35.Text = "Sampiyon Trabzonspor";
                pictureBox1.ImageLocation = "C:\\Users\\YusufSahin\\Desktop\\b";
            }
        }

   
    }
}
