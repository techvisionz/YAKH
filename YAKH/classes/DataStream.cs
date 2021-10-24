using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YAKH.classes
{
    public class DataStream
    {
        int _counter;
        int _lastCounter;
        public int ChartCounter { get; set; }
        public int ChartThreshold { get; set; }
        public List<ChartData> ChartData { get; set; }

        public DataStream()
        {
            this._counter = 0;
            this._lastCounter = 0;

            this.ChartCounter = 0;
            this.ChartThreshold = 10;
            this.ChartData = new List<ChartData>();
        }

        public void increment()
        {
            this._counter++;
        }

        public void resetCounter()
        {
            this._counter = 0; ;
        }

        public int total()
        {
            return this._counter;
        }

        public int addChartData(DateTime dt)
        {
            int newCounterValue = 0;
            this.ChartCounter++;
            if (this.ChartCounter % this.ChartThreshold == 0)
            {
                this.ChartCounter = 0;
                this.ChartData.Clear();
            }

            newCounterValue = this._counter - this._lastCounter;
            this._lastCounter = this._counter;
            this.ChartData.Add(new ChartData(dt, newCounterValue));
            return newCounterValue;
        }
    }
}
