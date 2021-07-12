/* Project:         Assignment Set 3 - Program 8
 * Date created:    September 29, 2020
 * Date modified:   October 8, 2020
 * Developed by:    Ahmad Zineddin
 * Class name:      PaySlip
 * Description:     Business Logic class for calculating pay slip for an employee
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZineddinAS3
{
    class PaySlip
    {
        public readonly string employeeName { get; set; }
        public readonly decimal hoursWorked { get; set; }
        public readonly decimal payRate { get; set; }
        public readonly decimal netPay { get; set; }
    }
}
