using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate1
{
    class AtomicCalculator
    {
        public int x { get; private set; }
        public int y { get; private set; }

        public Func<int> GetNumberFromUser { get; set; }
        public Action MenuPrinter { get; set; }
        public Func<int> GetUserChoice { get; set; }
        public Func<int, int, int, double> Calculate { get; set; }
        public Action<double> ResultPrinter { get; set; }

        public Run()
        {
            
            double sum;
            x = GetNumberFromUser.Invoke();
            y = GetNumberFromUser.Invoke();
            MenuPrinter.Invoke();
            int choice = GetUserChoice.Invoke();
            sum = Calculate.Invoke(x, y, choice);

        }

    }
}
