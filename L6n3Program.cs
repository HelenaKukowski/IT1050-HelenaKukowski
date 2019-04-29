using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06number03
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] seasons = { "Winter", "Spring", "Summmer", "Fall" };
            Console.WriteLine();
            foreach (string value in seasons)
                Console.Write("      {0}", value);
            Console.ReadLine();
        }
    }
}
