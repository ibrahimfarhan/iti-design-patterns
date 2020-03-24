using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern.Entities
{
    public class FibonacciSeries : IteratorAggregate
    {
        public int[] Numbers { get; set; }

        public FibonacciSeries(int number)
        {
            Numbers = new int[number];

            AddFibonacciNumbers(number);
        }

        public void AddFibonacciNumbers(int number)
        {
            if (number < 0)
            {
                return;
            }

            Numbers[0] = 0;

            if (number == 0)
            {
                return; 
            }

            Numbers[1] = 1;

            for (int i = 2; i < number; i++)
            {
                Numbers[i] = Numbers[i - 1] + Numbers[i - 2];
            }
        }

        public override IEnumerator GetEnumerator()
        {
            return new FibonacciSeriesIterator(this);
        }
    }
}
