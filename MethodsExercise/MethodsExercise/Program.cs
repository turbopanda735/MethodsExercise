using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExercise
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome...");
            Console.WriteLine("Please enter the name you want to be called...");
            var name = Console.ReadLine();
            Console.WriteLine($"Great! Hello, {name}!");
            Console.WriteLine("I have to ask you some questions now. What is your favorite color?");
            var color = Console.ReadLine();
            Console.WriteLine("And what about a favorite animal?");
            var animal = Console.ReadLine();
            Console.WriteLine("Finally, how about your favorite band?");
            var band = Console.ReadLine();
            Console.WriteLine($"Awesome job, {name}! I bet you would like a {color} {animal} that plays {band}'s music!");
            Console.ReadLine();
        }
    }
}
