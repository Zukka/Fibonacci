using System;
using System.Collections.Generic;

namespace Fibonacci
{
    public class FibonacciCalculator
    {

        private List<int> fibonacciList;

        public List<int> getListOfFibonacciNumbers() {
            return fibonacciList;
        }

        public void RequestedListSize(int number) {
            fibonacciList = new List<int>();

            if (number == 0) fibonacciList = null;
            if (number == 1) fibonacciList.Add(1);
            if (number >= 2) {
                fibonacciList.Add(1);
                fibonacciList.Add(1);

            }
            if (number > 2) {
                for (int i = 2; i < number; i++) {
                    fibonacciList.Add( fibonacciList[i - 2] + fibonacciList[i - 1]);
                }
            }
        }

        public FibonacciCalculator()
        {
        }
    }
}
