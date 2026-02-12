// See https://aka.ms/new-console-template for more information

using System;


class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name1 = "Brianna";
        int age1 = 19;
        
        DisplayUserInfo(name1, age1);

        
        int num1 = 20; int num2 = 30;
        int result = CalculateSum(num1, num2);
        
        Console.WriteLine(result);

        int variable1 = 1; 


    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to Module 5!");

        Console.WriteLine(variable1);
    }

    static void DisplayUserInfo(string name, int age)
    {
        Console.WriteLine($"Name: {name}, Age: {age}");
    }

    static int CalculateSum(int a, int b)
    {
        return a + b;
        
    }
    
}