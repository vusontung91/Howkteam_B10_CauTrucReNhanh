using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hokteam_B10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string strk;
            Console.WriteLine("Nhap so k:");
            strk = Console.ReadLine();
            int k = int.Parse(strk);
            switch (k)
            {
                case 3:
                    Console.WriteLine("Tung");
                    Console.ReadKey();
                    break;
                case 9:
                    Console.WriteLine("Thoc");
                    Console.ReadKey();
                    break;
                case 10:
                    Console.WriteLine("Huyen");
                    Console.ReadKey();
                    break;
                    
            }
            
            
        }
    }
}
