/* Project:         Assignment Set 3 - Program 6
 * Date created:    September 29, 2020
 * Date modified:   September 29, 2020
 * Developed by:    Ahmad Zineddin
 * Class name:      BMI 
 * Description:     Business Logic class for calculating Body Mass Index
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZineddinAS3
{
    class BMI
    {
        private string Username { get; set; }

        private int Userweight { get; set; }

        private int Userheight { get; set; }

        public BMI(string Name, int Weight, int Height)
        {
            this.Username = Name;
            this.Userweight = Weight;
            this.Userheight = Height;
        }

        public double calculateBMI()
        {
            //user weight * 703 / height^2
            const double BMI703 = 703;
            double cBMI = (this.Userweight * BMI703) / (Math.Pow(this.Userheight, 2));
            return cBMI;
        }
    }
}
