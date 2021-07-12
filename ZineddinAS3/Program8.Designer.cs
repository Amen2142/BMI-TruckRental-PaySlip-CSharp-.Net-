namespace ZineddinAS3
{
    partial class Program8
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
            this.lblEmployee = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblPayrate = new System.Windows.Forms.Label();
            this.txtcustName = new System.Windows.Forms.TextBox();
            this.numupdownBegOd = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnCreateSlip = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblDev = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numupdownBegOd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(223, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 39);
            this.label1.TabIndex = 14;
            this.label1.Text = "PaySlip Calculator";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmployee
            // 
            this.lblEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblEmployee.Location = new System.Drawing.Point(32, 66);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(191, 36);
            this.lblEmployee.TabIndex = 15;
            this.lblEmployee.Text = "Employee Name";
            // 
            // lblHours
            // 
            this.lblHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblHours.Location = new System.Drawing.Point(32, 118);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(191, 36);
            this.lblHours.TabIndex = 18;
            this.lblHours.Text = "Hours Worked";
            // 
            // lblPayrate
            // 
            this.lblPayrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPayrate.Location = new System.Drawing.Point(32, 170);
            this.lblPayrate.Name = "lblPayrate";
            this.lblPayrate.Size = new System.Drawing.Size(191, 36);
            this.lblPayrate.TabIndex = 19;
            this.lblPayrate.Text = "Pay Rate";
            // 
            // txtcustName
            // 
            this.txtcustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtcustName.Location = new System.Drawing.Point(305, 63);
            this.txtcustName.Name = "txtcustName";
            this.txtcustName.Size = new System.Drawing.Size(150, 26);
            this.txtcustName.TabIndex = 20;
            // 
            // numupdownBegOd
            // 
            this.numupdownBegOd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numupdownBegOd.Location = new System.Drawing.Point(305, 118);
            this.numupdownBegOd.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            this.numupdownBegOd.Name = "numupdownBegOd";
            this.numupdownBegOd.Size = new System.Drawing.Size(150, 26);
            this.numupdownBegOd.TabIndex = 21;
            this.numupdownBegOd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numericUpDown1.Location = new System.Drawing.Point(305, 168);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(150, 26);
            this.numericUpDown1.TabIndex = 22;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCreateSlip
            // 
            this.btnCreateSlip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCreateSlip.Location = new System.Drawing.Point(36, 236);
            this.btnCreateSlip.Name = "btnCreateSlip";
            this.btnCreateSlip.Size = new System.Drawing.Size(205, 46);
            this.btnCreateSlip.TabIndex = 25;
            this.btnCreateSlip.Text = "Create Pay Slip";
            this.btnCreateSlip.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblResult.Location = new System.Drawing.Point(305, 236);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(205, 46);
            this.lblResult.TabIndex = 26;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnExit.Location = new System.Drawing.Point(36, 401);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(154, 37);
            this.btnExit.TabIndex = 27;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClear.Location = new System.Drawing.Point(305, 312);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 32);
            this.btnClear.TabIndex = 28;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // lblDev
            // 
            this.lblDev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDev.Location = new System.Drawing.Point(634, 401);
            this.lblDev.Name = "lblDev";
            this.lblDev.Size = new System.Drawing.Size(154, 37);
            this.lblDev.TabIndex = 29;
            this.lblDev.Text = "Developed by: AZ";
            this.lblDev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Program8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDev);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCreateSlip);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.numupdownBegOd);
            this.Controls.Add(this.txtcustName);
            this.Controls.Add(this.lblPayrate);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.label1);
            this.Name = "Program8";
            this.Text = "Program8";
            ((System.ComponentModel.ISupportInitialize)(this.numupdownBegOd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblPayrate;
        private System.Windows.Forms.TextBox txtcustName;
        private System.Windows.Forms.NumericUpDown numupdownBegOd;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnCreateSlip;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblDev;
    }
}