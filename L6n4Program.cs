using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06number04
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] randomNumber = new int[1000];
            Random RandomNumber = new Random();
            for (int i = 0; i < 1000; i++)
            {
                randomNumber[i] = RandomNumber.Next(0, 100);
            }
            foreach (int j in randomNumber)
            {
                Console.WriteLine("{0}", j);
            }
        }
    }
}
