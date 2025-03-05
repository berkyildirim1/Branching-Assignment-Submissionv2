// Main program for Package Express shipping calculator
// Author: John Smith
// Date: 2024
using System;

class Program
{
    static void Main(string[] args)
    {
        // Display welcome message
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Get package weight from user
        Console.WriteLine("Please enter the package weight:");
        float packageMass = float.Parse(Console.ReadLine());

        // Check if package is too heavy
        if (packageMass > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return;
        }

        // Get package dimensions from user
        Console.WriteLine("Please enter the package width:");
        float packageWidth = float.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the package height:");
        float packageHeight = float.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the package length:");
        float packageLength = float.Parse(Console.ReadLine());

        // Calculate total dimensions
        float totalDimensions = packageWidth + packageHeight + packageLength;

        // Check if package is too large
        if (totalDimensions > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return;
        }

        // Calculate shipping cost
        // Formula: (width * height * length * weight) / 100
        float shippingQuote = (packageWidth * packageHeight * packageLength * packageMass) / 100;

        // Display the shipping quote
        Console.WriteLine($"Your estimated total for shipping this package is: ${shippingQuote:F2}");
        Console.WriteLine("Thank you!");
    }
} 