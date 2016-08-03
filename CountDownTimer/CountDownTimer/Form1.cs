using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountDownTimer
{
    public partial class Form1 : Form
    {
        private int _totalTime;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void timer2_Tick(object sender, EventArgs e)
        {
           
            
            if (_totalTime > 1)
            {
                _totalTime = _totalTime - 1;
                textBox4.Text = _totalTime + " seconds";
            }
            else
            {

                timer2.Stop();
                textBox4.Text = "Time's up!";
            }
        }


        public void button1_Click(object sender, EventArgs e)
        {
            int hours;
            int minutes;
            int seconds;

            if (int.TryParse(textBox2.Text,out hours))
            {
                MessageBox.Show("Invalid hours");
                return;
            }

            if (int.TryParse(textBox1.Text, out minutes))
            {
                MessageBox.Show("Invalid minutes");
                return;
            }

            if (int.TryParse(textBox3.Text, out seconds))
            {
                MessageBox.Show("Invalid seconds");
                return;
            }

            hours = hours * 3600;
            minutes = minutes * 60;
            _totalTime = hours + minutes + seconds;
            textBox4.Text = _totalTime + " seconds";
            timer2.Enabled = true;
        }
    }
}
