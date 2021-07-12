namespace ZineddinAS3
{
    partial class Program7
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
            this.lblDev = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcustName = new System.Windows.Forms.TextBox();
            this.numupdownBegOd = new System.Windows.Forms.NumericUpDown();
            this.numupdownNumDays = new System.Windows.Forms.NumericUpDown();
            this.numupdownEndOd = new System.Windows.Forms.NumericUpDown();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCreateRental = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numupdownBegOd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numupdownNumDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numupdownEndOd)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDev
            // 
            this.lblDev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDev.Location = new System.Drawing.Point(634, 395);
            this.lblDev.Name = "lblDev";
            this.lblDev.Size = new System.Drawing.Size(154, 37);
            this.lblDev.TabIndex = 0;
            this.lblDev.Text = "Developed by: AZ";
            this.lblDev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnExit.Location = new System.Drawing.Point(39, 395);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(154, 37);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(222, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 39);
            this.label1.TabIndex = 13;
            this.label1.Text = "Truck Rental Calculator";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(35, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 36);
            this.label2.TabIndex = 14;
            this.label2.Text = "Customer Name";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(35, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(334, 36);
            this.label3.TabIndex = 15;
            this.label3.Text = "Number of Days Rented";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(35, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(334, 36);
            this.label4.TabIndex = 16;
            this.label4.Text = "Ending Odometer Reading";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(35, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(334, 36);
            this.label5.TabIndex = 17;
            this.label5.Text = "Beginning Odometer Reading";
            // 
            // txtcustName
            // 
            this.txtcustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtcustName.Location = new System.Drawing.Point(589, 72);
            this.txtcustName.Name = "txtcustName";
            this.txtcustName.Size = new System.Drawing.Size(150, 26);
            this.txtcustName.TabIndex = 18;
            // 
            // numupdownBegOd
            // 
            this.numupdownBegOd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numupdownBegOd.Location = new System.Drawing.Point(589, 132);
            this.numupdownBegOd.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            this.numupdownBegOd.Name = "numupdownBegOd";
            this.numupdownBegOd.Size = new System.Drawing.Size(150, 26);
            this.numupdownBegOd.TabIndex = 19;
            this.numupdownBegOd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numupdownNumDays
            // 
            this.numupdownNumDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numupdownNumDays.Location = new System.Drawing.Point(589, 250);
            this.numupdownNumDays.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numupdownNumDays.Name = "numupdownNumDays";
            this.numupdownNumDays.Size = new System.Drawing.Size(150, 26);
            this.numupdownNumDays.TabIndex = 20;
            this.numupdownNumDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numupdownEndOd
            // 
            this.numupdownEndOd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numupdownEndOd.Location = new System.Drawing.Point(589, 190);
            this.numupdownEndOd.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            this.numupdownEndOd.Name = "numupdownEndOd";
            this.numupdownEndOd.Size = new System.Drawing.Size(150, 26);
            this.numupdownEndOd.TabIndex = 21;
            this.numupdownEndOd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClear.Location = new System.Drawing.Point(589, 360);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 32);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblResult.Location = new System.Drawing.Point(534, 304);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(205, 46);
            this.lblResult.TabIndex = 23;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCreateRental
            // 
            this.btnCreateRental.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCreateRental.Location = new System.Drawing.Point(297, 304);
            this.btnCreateRental.Name = "btnCreateRental";
            this.btnCreateRental.Size = new System.Drawing.Size(205, 46);
            this.btnCreateRental.TabIndex = 24;
            this.btnCreateRental.Text = "Create Truck Rental";
            this.btnCreateRental.UseVisualStyleBackColor = true;
            this.btnCreateRental.Click += new System.EventHandler(this.btnCreateRental_Click);
            // 
            // Program7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCreateRental);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.numupdownEndOd);
            this.Controls.Add(this.numupdownNumDays);
            this.Controls.Add(this.numupdownBegOd);
            this.Controls.Add(this.txtcustName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblDev);
            this.Name = "Program7";
            this.Text = "Program7";
            ((System.ComponentModel.ISupportInitialize)(this.numupdownBegOd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numupdownNumDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numupdownEndOd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDev;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcustName;
        private System.Windows.Forms.NumericUpDown numupdownBegOd;
        private System.Windows.Forms.NumericUpDown numupdownNumDays;
        private System.Windows.Forms.NumericUpDown numupdownEndOd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnCreateRental;
    }
}