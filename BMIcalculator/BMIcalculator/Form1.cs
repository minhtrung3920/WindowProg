using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMIcalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.btnCompute.Click += btnCompute_Click;
        }

        void btnCompute_Click(object sender, EventArgs e)
        {
            int Height = int.Parse(this.txtHeight.Text);
            int Weight = int.Parse(this.txtWeight.Text);
            double ComBine = Math.Floor(Weight / (Math.Pow(Height, 2) / 10000));
            this.txtBMI.Text = ComBine.ToString();

            if (ComBine < 18.5) { this.lblNote.Text = "Underweight"; }
            else if (ComBine > 18.5) { this.lblNote.Text = "Overweight"; }
            else { this.lblNote.Text = "Normal"; }
        }
    }
}
