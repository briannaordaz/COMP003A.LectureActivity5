// See https://aka.ms/new-console-template for more information

using System;


class Program
{
    static void Main(string[] args)
    {
        DisplayWellcome();
    }

    static void DisplayWellcome()
    {
        Console.WriteLine("Welcome to Module 5!");
    }

    static void DisplayUserInfo(string name, int age)
    {
        Console.WriteLine($"Name: {name}, Age: {age}");
    }
    
    
}