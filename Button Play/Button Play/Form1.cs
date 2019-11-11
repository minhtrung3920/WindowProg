using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Button_Play
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Timer time = new Timer();
            InitializeComponent();

            time.Interval = 1000 / 24;
            time.Tick += time_Tick;
            // time.Start();

            this.button1.Click += button1_Click;
            this.KeyDown += Form1_KeyDown;
        }

        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int x = this.button1.Location.X;
            int y = this.button1.Location.Y;
            //move button
            int delta = 15;
            switch (e.KeyCode)
            {
                case Keys.W:
                    this.button1.Location = new Point(x, y - delta);
                    break;
                case Keys.S:
                    this.button1.Location = new Point(x, y + delta);
                    break;
                case Keys.A:
                    this.button1.Location = new Point(x - delta, y);
                    break;
                case Keys.D:
                    this.button1.Location = new Point(x + delta, y);
                    break;
            }
        }

        void button1_Click(object sender, EventArgs e)
        {
            // this.time.Stop();
        }

        void time_Tick(object sender, EventArgs e)
        {
            int x = this.button1.Location.X;
            int y = this.button1.Location.Y;
            this.button1.Location = new Point(x, y + 10);
            //vi tri drop
            if (y > 1000)
            {
                Random random = new Random();
                x = random.Next(this.Width);
                this.button1.Location = new Point(x, 0);
            }
            
        }
    }
}
