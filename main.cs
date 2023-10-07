using System;

class Program
{
    static void Main()
    {
        const double CentimetersInInch = 2.54;

        
        Console.Write("Enter the measurement in inches: ");
        string input = Console.ReadLine();

        if (double.TryParse(input, out double inches))
        {
            
            double centimeters = inches * CentimetersInInch;

            
            Console.WriteLine($"{inches} inches is {centimeters} centimeters.");
        }
        else
        {
            
            Console.WriteLine("Invalid input");
        }
    }
}