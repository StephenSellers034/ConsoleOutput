using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Output;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Whats Your name? :");// : allows user input but readline allows typeing of and reads User Input
        //writeline has 2 functions Write, and WriteLine. Write gives response on same line, While WriteLine starts new line.
        string name = Console.ReadLine();// created variable

        Console.WriteLine("Your name is: " + name);// string concatination adds string and append to variables

        Console.ReadLine();// should go at bottom of program so input wont be closed thats gathered during writeline

        Console.Write("What is your age? :");

        string ageinput = Console.ReadLine();

        int age = Convert.ToInt32(ageinput); // turns the string into a interger so if needed for future use it would be stored in proper variable

        Console.WriteLine("Your age is: " + age);

        Console.ReadLine();

        Console.Write("Whats your last name? :");

        string last = Console.ReadLine();

        Console.WriteLine("Your last name is :" + last);

        Console.ReadLine();

    }
}

