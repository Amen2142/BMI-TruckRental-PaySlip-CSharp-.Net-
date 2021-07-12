namespace ZineddinAS3
{
    partial class Program6
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
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.numupdownWeight = new System.Windows.Forms.NumericUpDown();
            this.numupdownHeight = new System.Windows.Forms.NumericUpDown();
            this.btnCreateBMI = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numupdownWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numupdownHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDev
            // 
            this.lblDev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDev.Location = new System.Drawing.Point(583, 395);
            this.lblDev.Name = "lblDev";
            this.lblDev.Size = new System.Drawing.Size(205, 46);
            this.lblDev.TabIndex = 0;
            this.lblDev.Text = "Developed by: AZ";
            this.lblDev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWeight
            // 
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblWeight.Location = new System.Drawing.Point(12, 153);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(205, 46);
            this.lblWeight.TabIndex = 2;
            this.lblWeight.Text = "User Weight (Pounds)";
            this.lblWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblName.Location = new System.Drawing.Point(12, 81);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(205, 46);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name of User";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(261, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 46);
            this.label4.TabIndex = 4;
            this.label4.Text = "BMI Calculator";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHeight
            // 
            this.lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblHeight.Location = new System.Drawing.Point(12, 225);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(205, 46);
            this.lblHeight.TabIndex = 5;
            this.lblHeight.Text = "User Height (Inches)";
            this.lblHeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtUsername.Location = new System.Drawing.Point(267, 87);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(199, 26);
            this.txtUsername.TabIndex = 6;
            // 
            // numupdownWeight
            // 
            this.numupdownWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numupdownWeight.Location = new System.Drawing.Point(267, 160);
            this.numupdownWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numupdownWeight.Name = "numupdownWeight";
            this.numupdownWeight.Size = new System.Drawing.Size(199, 26);
            this.numupdownWeight.TabIndex = 7;
            this.numupdownWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numupdownHeight
            // 
            this.numupdownHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numupdownHeight.Location = new System.Drawing.Point(267, 236);
            this.numupdownHeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numupdownHeight.Name = "numupdownHeight";
            this.numupdownHeight.Size = new System.Drawing.Size(199, 26);
            this.numupdownHeight.TabIndex = 8;
            this.numupdownHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numupdownHeight.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // btnCreateBMI
            // 
            this.btnCreateBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCreateBMI.Location = new System.Drawing.Point(16, 283);
            this.btnCreateBMI.Name = "btnCreateBMI";
            this.btnCreateBMI.Size = new System.Drawing.Size(205, 46);
            this.btnCreateBMI.TabIndex = 9;
            this.btnCreateBMI.Text = "Create BMI:";
            this.btnCreateBMI.UseVisualStyleBackColor = true;
            this.btnCreateBMI.Click += new System.EventHandler(this.btnCreateBMI_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClear.Location = new System.Drawing.Point(283, 350);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(158, 32);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnExit.Location = new System.Drawing.Point(44, 350);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(158, 32);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblResult.Location = new System.Drawing.Point(264, 283);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(205, 46);
            this.lblResult.TabIndex = 12;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Program6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCreateBMI);
            this.Controls.Add(this.numupdownHeight);
            this.Controls.Add(this.numupdownWeight);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblDev);
            this.Name = "Program6";
            this.Text = "Program6";
            ((System.ComponentModel.ISupportInitialize)(this.numupdownWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numupdownHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDev;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.NumericUpDown numupdownWeight;
        private System.Windows.Forms.NumericUpDown numupdownHeight;
        private System.Windows.Forms.Button btnCreateBMI;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblResult;
    }
}