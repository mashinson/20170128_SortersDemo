using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20170128_SortersDemo
{
    abstract class Sorter
    {
        public const int DEF_SIZE = 10000;

        #region ctors

        public Sorter(int size = DEF_SIZE)
        {

            _numbers = new double[size];
            // инициализация с помощью Random !!!
        }

        public Sorter(double[] numbers)
        {
            _numbers = (double[])numbers.Clone();
        }

        #endregion

        public abstract string SortName { get; }
        public abstract void Sort();

        protected bool IsLargeThan(double a, double b)
        {
            ++_compareCount;

            return a > b;
        }

        protected void Swap(ref double a, ref double b)
        {
            ++_swapCount;

            double c = b;
            b = a;
            a = c;
        }

        public double Time
        {
            get
            {
                return _time;
            }
            set 
            {
                _time = value;

            }

        }

        public override string ToString()
        {
            return string.Format("SortName: {0}, compareCount: {1}, swapCount: {2}, time: {3}", SortName, _compareCount, _swapCount, Time);
        }

        protected double[] _numbers = null;

        private uint _compareCount = 0;
        private uint _swapCount = 0;
        private double _time = 0;
    }
}
