using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
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
            int totalAmount = int.Parse(this.txtAmount.Text);
            double taxPercentage = double.Parse(this.lblTaxPercent.Text.Replace("%", ""));
            double totalDude = (taxPercentage / 100 + 1)  * totalAmount;
            this.txtDude.Text = totalAmount.ToString();
        }       
    }
}
