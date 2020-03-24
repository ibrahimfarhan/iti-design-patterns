using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern.Entities
{
    public class FibonacciSeriesIterator : Iterator
    {
        private FibonacciSeries series;
        private int currentPosition = -1;

        public FibonacciSeriesIterator(FibonacciSeries series)
        {
            this.series = series;
        }

        public override object Current()
        {
            return series.Numbers[currentPosition];
        }

        public override bool MoveNext()
        {
            int newPosition = currentPosition + 1;

            if (newPosition >= 0 && newPosition < series.Numbers.Length)
            {
                currentPosition = newPosition;
                return true;
            }

            return false;
        }

        public override void Reset()
        {
            currentPosition = 0;
        }
    }
}
