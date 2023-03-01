using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace MyStopwatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Stopwatch stopWatch;
        void Form1_Load(object sender, EventArgs e)
        {
            stopWatch = new Stopwatch();
        }

        void button1_Click(object sender, EventArgs e)
        {
            stopWatch.Start();
        }

        void button2_Click(object sender, EventArgs e)
        {
            stopWatch.Stop();
        }

        void button3_Click(object sender, EventArgs e)
        {
            stopWatch.Reset();
        }

        void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = string.Format("{0:hh\\:mm\\:ss\\.ff}", stopWatch.Elapsed);
        }
    }
}
