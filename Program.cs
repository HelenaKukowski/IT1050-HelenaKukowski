using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06number07
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

           
            foreach (string name in names)
            {
                for (int i = 0; i < names.Length; i++)
                {
                    Console.WriteLine("{0, 2}. {1}", i, names[i]);
                    
                }
                Console.ReadLine();
            }
            
        }
    }
}
