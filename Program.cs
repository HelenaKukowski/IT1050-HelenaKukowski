//Fig. 3.18: Addition,cs
//Displaying the sum of two numbers input from the keyboard.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Addition
{
    //Main method begins execution of C# application
    public static void Main(string[] args)
    {
        int number1; //declare first number to add
        int number2; //declare second number to add
        int sum; //delare sum of number1 and number2

        Console.Write("Enter first integer:"); //prompt user
        //read first number from user
        number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second integer:"); //prompt user
        //read second number from user
        number2 = Convert.ToInt32(Console.ReadLine());

        sum = number1 + number2; //add numbers
        Console.WriteLine("Sum is {0}", sum); //display sum
        Console.WriteLine("{0}\n{1}", "Hello World!", "From Helena Kukowski.");
        Console.WriteLine("Hello World!\tFrom Helena Kukowski.");
        }
    }
    
