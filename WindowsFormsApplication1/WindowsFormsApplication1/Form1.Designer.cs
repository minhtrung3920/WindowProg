namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblTaxPercent = new System.Windows.Forms.Label();
            this.lblDude = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTaxPer = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtDude = new System.Windows.Forms.TextBox();
            this.btnCompute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tax Calculator";
            // 
            // lblAmount
            // 
            this.lblAmount.AccessibleName = "lblAmount";
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(42, 86);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(92, 17);
            this.lblAmount.TabIndex = 1;
            this.lblAmount.Text = "Total Amount";
            // 
            // lblTaxPercent
            // 
            this.lblTaxPercent.AccessibleName = "lblPercent";
            this.lblTaxPercent.AutoSize = true;
            this.lblTaxPercent.Location = new System.Drawing.Point(42, 141);
            this.lblTaxPercent.Name = "lblTaxPercent";
            this.lblTaxPercent.Size = new System.Drawing.Size(108, 17);
            this.lblTaxPercent.TabIndex = 1;
            this.lblTaxPercent.Text = "Tax Percentage";
            // 
            // lblDude
            // 
            this.lblDude.AccessibleName = "lblTotal";
            this.lblDude.AutoSize = true;
            this.lblDude.Location = new System.Drawing.Point(42, 195);
            this.lblDude.Name = "lblDude";
            this.lblDude.Size = new System.Drawing.Size(78, 17);
            this.lblDude.TabIndex = 1;
            this.lblDude.Text = "Total Dude";
            // 
            // lblTaxPer
            // 
            this.lblTaxPer.AutoSize = true;
            this.lblTaxPer.Location = new System.Drawing.Point(294, 141);
            this.lblTaxPer.Name = "lblTaxPer";
            this.lblTaxPer.Size = new System.Drawing.Size(40, 17);
            this.lblTaxPer.TabIndex = 3;
            this.lblTaxPer.Text = "7.5%";
            // 
            // txtAmount
            // 
            this.txtAmount.AccessibleName = "txtAmount";
            this.txtAmount.Location = new System.Drawing.Point(282, 86);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(118, 22);
            this.txtAmount.TabIndex = 4;
            // 
            // txtDude
            // 
            this.txtDude.AccessibleName = "txtDude";
            this.txtDude.Location = new System.Drawing.Point(282, 190);
            this.txtDude.Name = "txtDude";
            this.txtDude.Size = new System.Drawing.Size(118, 22);
            this.txtDude.TabIndex = 4;
            // 
            // btnCompute
            // 
            this.btnCompute.AccessibleDescription = "btnCompute";
            this.btnCompute.AccessibleName = "btnCompute";
            this.btnCompute.Location = new System.Drawing.Point(123, 281);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(159, 55);
            this.btnCompute.TabIndex = 5;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 395);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.txtDude);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblTaxPer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblDude);
            this.Controls.Add(this.lblTaxPercent);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblTaxPercent;
        private System.Windows.Forms.Label lblDude;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtDude;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Label lblTaxPer;
    }
}

