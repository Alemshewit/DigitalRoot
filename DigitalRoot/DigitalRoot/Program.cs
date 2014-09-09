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
            Console.WriteLine(DigitalRoot("31337"));
            Console.WriteLine(DigitalRoot("45734"));

            //keep console open
            Console.ReadKey();
        }

        //create a function DigitalRoot that takes an argument and gives the digital root value of it.
        static int DigitalRoot(string rootThis)
        {
            //declare a variable to hold the sum of the string after we loop through it in the for loop
            int rootSum = 0;
            //run a for loop through the string until all characters have gone through the loop
            for (int i = 0; i < rootThis.Length; i++)
            {
                //take each character in the index and convert them to strings and then into integers
                //and add them to the variable rootSum each time the loop is excuted
                rootSum += int.Parse(rootThis[i].ToString());

            }

            //take the rootSum and convert it to strings before we can get the sum, add them up, convert the x to 
            //string and then to an integer and store in an int variable input
            int input = rootSum.ToString().Sum(x => int.Parse(x.ToString()));
            //return the value of input
            return input;
        }
    }
}
