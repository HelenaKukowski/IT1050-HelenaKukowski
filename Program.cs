using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab0number02
{
    class Program
    {
        static void Main()
        {
            string[] months = new string[12];
            {
                months[0] = "January";
                months[1] = "February";
                months[2] = "March";
                months[3] = "April";
                months[4] = "May";
                months[5] = "June";
                months[6] = "July";
                months[7] = "August";
                months[8] = "September";
                months[9] = "October";
                months[10] = "November";
                months[11] = "December";
                for (int i = 0; i <= months.Length-1; i++)
                {
                    Console.WriteLine("{0,2}. {1}", i, months[i]);
                }

            }
        }
    }
}
