<<<<<<< HEAD
﻿// See https://aka.ms/new-console-template for more information
using System.Diagnostics.CodeAnalysis;

internal class Program
    {

        public static void Main()
        {
            string temp;
  
           
            Console.WriteLine("write down you name: ");
            temp = Console.ReadLine();
            Console.WriteLine($"congrats your a member now {temp}");
           
            age();

            Console.WriteLine("this is just to test for merge conflicts and how to solve it");
            Console.WriteLine("we cant figure it out");
        }
        public static void age()
        {
        string ageAsString;
        Console.WriteLine("Please enter your age: ");
        ageAsString = Console.ReadLine();
        int age = Convert.ToInt32(ageAsString);
        Console.WriteLine($"you were born in {2023 - age}");
       

        
        
        }
    }
