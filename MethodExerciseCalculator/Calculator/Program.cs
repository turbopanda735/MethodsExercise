using System;
using System.Collections.Generic;

class Demo
{
    public static void Main()
    {
        Console.WriteLine("Welcome to the calculator...");
        Console.WriteLine("Please enter the amount of numbers you want calculated.");
        int howMany = Convert.ToInt32(Console.ReadLine());       
        string[] input = new string[howMany];
        Console.WriteLine($"Enter {howMany} numbers...");
        
        for (int i = 0; i < howMany; i++)
            input[i] = Console.ReadLine();
        //for this, i will assume all input is valid for a calculator

        int[] userInputs = Array.ConvertAll(input, i => int.Parse(i)); 

        Console.WriteLine("Please enter 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division.");
        int operation = Convert.ToInt32(Console.ReadLine());
        int result = 0;
        switch (operation)
        {
            case 1:
                {
                    result = Addition(userInputs);
                    break;
                }
            case 2:
                {
                    result = Subtraction(userInputs);
                    break;
                }
            case 3:
                {
                    result = Multiplication(userInputs);
                    break;
                }
            case 4:
                {
                    result = Division(userInputs);
                    break;
                }
            default:
                break;
        }
        Console.WriteLine("{0}", result);
    }
    static int Addition(params int[] userInput)
    {
        int total = userInput[0];
        for (int i = 1; i < userInput.Length; i++)
            total += userInput[i];
        return total;
    }
    static int Subtraction(params int[] userInput)
    {
        int total = userInput[0];
        for (int i = 1; i < userInput.Length; i++)
            total -= userInput[i];
        return total;
    }
    static int Multiplication(params int[] userInput)
    {
        int total = userInput[0];
        for (int i = 1; i < userInput.Length; i++)
            total *= userInput[i];
        return total;
    }
    static int Division(params int[] userInput)
    {
        int total = userInput[0];
        for (int i = 1; i < userInput.Length; i++)
            total /= userInput[i];
        return total;
    }
}



