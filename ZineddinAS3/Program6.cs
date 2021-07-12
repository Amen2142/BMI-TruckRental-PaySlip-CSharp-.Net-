/* Project:         Assignment Set 3 - Program 6
 * Date created:    September 29, 2020
 * Date modified:   October 8, 2020
 * Developed by:    Ahmad Zineddin
 * Class name:      Program6
 * Description:     Form class for BMI calculator
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZineddinAS3
{
    public partial class Program6 : Form
    {
        public Program6()
        {
            InitializeComponent();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblResult.Text = null;
            txtUsername.Text = null;
            numupdownHeight.Value = 0;
            numupdownWeight.Value = 0;
        }

        private void btnCreateBMI_Click(object sender, EventArgs e)
        {
            BMI BMI1 = new BMI(txtUsername.Text, Convert.ToInt32(numupdownWeight.Value), Convert.ToInt32(numupdownHeight.Value));
            double calcBMI = BMI1.calculateBMI();
            lblResult.Text = txtUsername.Text + "'s BMI: " + calcBMI;
        }
    }
}
