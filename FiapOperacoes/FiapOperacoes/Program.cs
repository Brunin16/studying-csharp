using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapOperacoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("dois digitos");
            Double read1 = Convert.ToDouble( Console.ReadLine());
            Double read2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("soma:" +( read1+ read2));
            Console.WriteLine("divisao" + ( read1/ read2));


            Console.ReadKey();
        }
    }
}
