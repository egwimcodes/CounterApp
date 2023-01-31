using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perpustakaan_sederhana
{
    public partial class Form1 : Form
    {

        

        public Form1()
        {
            InitializeComponent();

        }
        private void Button1_Click(object sender, EventArgs e)
        {
            int counter, time, timer;
            int trig = 0;
            counter = int.Parse(lbl_counter.Text);
            time = int.Parse(textBox1.Text);

            lbl_counter.Text = textBox1.Text;
            counter = time;
            if (trig == 0)
            {
                timer1 = new Timer();
                timer1.Tick += new EventHandler(Timer1_Tick);
                
                timer1.Interval = 1000;
                trig = 1;
            }
            timer1.Enabled = true;
            timer1.Start();



        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

            int waktu = int.Parse(textBox1.Text);
            
            waktu--;
            lbl_counter.Text = waktu.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            lbl_counter.Text = "0";
        }
    }
}
