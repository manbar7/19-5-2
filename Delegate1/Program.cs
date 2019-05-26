using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate1
{
    class Program
    {
      
        // method void which accpets String
        public delegate void SignatureGetStringReturnVoid(string message);

        static SignatureGetStringReturnVoid method1;

        // void which accepts String
        static void MyPrinter(string message)
        {
            Console.WriteLine(message);
        }

       

        private static int Add(int a,int b)
        {
            return a + b;
        }

        private static int Mul(int a,int b)
        {
            return a * b;
        }
        private static int Div(int a,int b)
        {
            return a / b;
        }
        private static int Sub(int a,int b)
        {
            return a - b;
        }

        

        static void Execute1(SignatureGetStringReturnVoid func)
        {
            if (func != null)
            {
                func.Invoke("Hello Again!");
            }
        }




      
    }
}
