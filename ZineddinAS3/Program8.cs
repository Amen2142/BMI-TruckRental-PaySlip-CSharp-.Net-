/* Project:         Assignment Set 3 - Program 8
 * Date created:    September 29, 2020
 * Date modified:   October 8, 2020
 * Developed by:    Ahmad Zineddin
 * Class name:      Program8
 * Description:     Form class for PaySlip
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
    public partial class Program8 : Form
    {
        public Program8()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
