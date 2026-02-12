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
        
        /*
        int variable1 = 1;   
        */


        if (true)
        {
            int variable3 = 100;
            Console.WriteLine(variable3);
            
        }
        
        
        /*
        Console.WriteLine(variable3); //  Program.cs(35, 27): [CS0103] The name 'variable3' does not exist in the current context
        */



        for (int counter = 0; counter <= 10; counter++)
        {
            Console.WriteLine(counter);
            
        }
        
        /*
        Console.WriteLine(counter);   // Cannot resolve symbol 'counter'
        */
        
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to Module 5!");
        /*
        Console.WriteLine(variable1); //   Program.cs(44, 27): [CS0103] The name 'variable1' does not exist in the current context
        */
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

/* 
   Why method variables are not accessible in Main:
   Method variables are not accessible in Main because every method has different scope and memory space, anything inside that method can be accessed only in that method
   
   Why block variables do not exist outside { }:
   variables do not exist outside { } because once the block of code is executed, the brackets are what helps define where the variables can be accessed and where they cannot be accessed
   
   Why scope improves program safety:
   scopes help improve program safety because they help prevent accidentally accessing variables from other methods
   
   */