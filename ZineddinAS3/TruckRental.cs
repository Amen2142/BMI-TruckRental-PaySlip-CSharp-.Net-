/* Project:         Assignment Set 3 - Program 7
 * Date created:    September 29, 2020
 * Date modified:   September 29, 2020
 * Developed by:    Ahmad Zineddin
 * Class name:      TruckRental
 * Description:     Business Logic class for calculating cost of renting a truck
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZineddinAS3
{
    class TruckRental
    {
        public string CustomerName { get; set; }
        public decimal RentalCharge { get; private set; }
        private int EndingOdometerReading { get; set; }
        private int BeginningOdometerReading { get; set; }
        private int NumDaysRented { get; set; }

        public TruckRental()
        {

        }

        public TruckRental(string custName, int endOR, int begOR, int numDays)
        {
            this.CustomerName = custName;
            this.EndingOdometerReading = endOR;
            this.BeginningOdometerReading = begOR;
            this.NumDaysRented = numDays;
            calcRentCharge();
        }

        private void calcRentCharge()
        {
            const decimal dayCost = 52.75M;
            const decimal mileCost = 0.69M;
            int perDay = NumDaysRented;
            int perMile = EndingOdometerReading - BeginningOdometerReading;
            this.RentalCharge = ((dayCost * perDay) + (mileCost * perMile));
        }
    }
}
