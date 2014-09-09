using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            //call up the function DigitalRoot with a string parameter and print the value to the console.
            Console.WriteLine(DigitalRoot("3425"));
            //keep console open
            Console.ReadKey();
        }

        //create a function DigitalRoot that takes an argument and gives the digital root value of it.
        static int DigitalRoot(string rootThis)
        {
            //take the string argument, convert to char array, add them up, convert the x to 
            //string and then to an integer and store in an int variable input
            int input = rootThis.ToCharArray().Sum(x => int.Parse(x.ToString()));
            //return the value of input
            return input;
        }
    }
}
