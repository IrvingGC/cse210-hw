using System;

class Program
{
    
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int favoriteNumber;
        while (!int.TryParse(Console.ReadLine(), out favoriteNumber))  
        {
            Console.Write("Please enter a valid number: ");
        }
        return favoriteNumber;
    }

    
    static int SquareNumber(int number)
    {
        return number * number;
    }

    
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }

    
    static void Main()
    {
        DisplayWelcome();  

        string userName = PromptUserName();  
        int favoriteNumber = PromptUserNumber();  
        int squaredNumber = SquareNumber(favoriteNumber);  
        
        DisplayResult(userName, squaredNumber);  
    }
}