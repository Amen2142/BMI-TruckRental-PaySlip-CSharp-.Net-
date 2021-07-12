/* Project:         Assignment Set 3 - Program 7
 * Date created:    September 29, 2020
 * Date modified:   October 8, 2020
 * Developed by:    Ahmad Zineddin
 * Class name:      Program7
 * Description:     Form class for TruckRental
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
    public partial class Program7 : Form
    {
        public Program7()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtcustName.Text = null;
            numupdownBegOd.Value = 0;
            numupdownEndOd.Value = 0;
            numupdownNumDays.Value = 0;
            lblResult.Text = null;
        }

        private void btnCreateRental_Click(object sender, EventArgs e)
        {
            TruckRental TRent = new TruckRental(txtcustName.Text, Convert.ToInt32(numupdownEndOd.Value), Convert.ToInt32(numupdownBegOd.Value), Convert.ToInt32(numupdownNumDays.Value));
            decimal calcCharge = TRent.RentalCharge;
            lblResult.Text = txtcustName.Text + "'s Truck Rental Cost: " + calcCharge;
        }
    }
}
