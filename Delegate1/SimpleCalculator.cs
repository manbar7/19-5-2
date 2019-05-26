using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate1
{
    class SimpleCalculator

    {
        public delegate int OperationFunc(int x, int y);

        private static int Add(int x, int y)
        {
            return x + y;
        }

        private static int Subtract(int x, int y)
        {
            return x - y;
        }
        private static int Multiply(int x, int y)
        {
            return x * y;
        }
        private static int Divide(int x, int y)
        {
            return x / y;
        }

        public double Calculate(int x, int y, int choice)
        {
            double result;
            if (choice == 1)
            {
                return result = Add(x, y);

            }
            if (choice == 2)
            {
                return result = Subtract(x, y);
            }
            if (choice == 3)
            {
                return result = Multiply(x, y);
            }
            if (choice == 4)
            {
                return result = Divide(x, y);
            }
            else return 0;

        }


    }
}
