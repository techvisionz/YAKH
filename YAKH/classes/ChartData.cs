using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YAKH.classes
{
    public class ChartData
    {
        public DateTime DateTime { get; set; }
        public int Counter { get; set; }

        public ChartData(DateTime dt, int c)
        {
            this.DateTime = dt;
            this.Counter = c;
        }
    }
}
