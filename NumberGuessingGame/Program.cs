﻿Console.WriteLine("Welcome to the Number Guesser Game!");
Console.Write("I'm thinking of a number from 1 to 10: ");

do
{
    var userChosenNumber = int.Parse(Console.ReadLine());

    var randomNumber = new Random().Next(1, 11);

    if (userChosenNumber == randomNumber)
    {
        Console.WriteLine("Congratulations! You have guessed the correct number 🎉");
        Console.WriteLine($"Guessed number: {userChosenNumber}");
        break;
    }
    else
    {
        Console.WriteLine($"Oops, wrong number, i was thinking of the number {randomNumber}");
        Console.Write("Try again! I'm thinking of a number from 1 to 10: ");
    }    
} while (true);


