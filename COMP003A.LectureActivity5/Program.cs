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
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to Module 5!");
    }

    static void DisplayUserInfo(string name, int age)
    {
        Console.WriteLine($"Name: {name}, Age: {age}");
    }
    
    
}