using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {// declare variables
            string name = "Anna";
            int age;

            //initialization
            name = "Anna";
            age = 5;

            //what will be seen on the console
            Console.WriteLine("There was once a girl called " + name);
            Console.WriteLine( name + " was" + age + " years of age.") ;
            Console.WriteLine( name + " never really liked her name.");

            //change variable values
            age = 10;
            name = "Kim";

            Console.WriteLine("At age " + age + " she changed her name to " + name);

            // to freeze the console
            Console.ReadLine();

            /* notes : you can also declare and initialize on the same line
             * e.g string name = "anna"
             */




        }
    }
}
