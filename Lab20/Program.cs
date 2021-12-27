using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20
{
    class Program
    {
        public delegate double MyDelegate(double r);
        public event MyDelegate Calculate;
        static void Main(string[] args)
        {
            MyDelegate myDelegate = new MyDelegate(Methodr);
            if (myDelegate != null)
            {
                double R = myDelegate(5);
                Console.WriteLine(R);
            }
           
            Console.ReadKey();
        }
        static double Methodr(double r)
        {
            return r;
            
        }
        static double MethodD(double r)
        {
            return 2 * Math.PI * r;
            Calculate?.Invoke("Длина окружности=")
        }
        static double MethodS(double r)
        {
            return  Math.PI * Math.Pow(r,2);
        }
        static double MethodV(double r)
        {
            return (4/3)*Math.PI * Math.Pow(r, 3);
        }
    }
}
