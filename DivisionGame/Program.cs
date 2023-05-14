﻿using System.ComponentModel.Design;
using System.Diagnostics;
using System.Timers;

Random random = new Random();


Console.WriteLine("This is a math game, see if you can guess the right answer in time");
Console.WriteLine("Try to solve the problems");
Console.WriteLine("Would you like to play y/n");
string isPlaying = Console.ReadLine();



Console.WriteLine("How many rounds would you like to play");
int numOfGames = Convert.ToInt32(Console.ReadLine());

Stopwatch timer = Stopwatch.StartNew();

for (int i = 0; i < numOfGames; i++)
{    

    int num1 = random.Next(1, 100);
    int num2 = random.Next(1, 100);

    Console.WriteLine($"What is {num1} + {num2} ");
    int answer = Convert.ToInt32(Console.ReadLine());

    if (answer == num1 + num2)
    {
        Console.WriteLine($"Correct! the answer is {answer}");
    }
    else Console.WriteLine("Sorry incorrect answer ");

}

timer.Stop();


Console.WriteLine($"You took {timer.Elapsed.TotalSeconds} seconds to answer {numOfGames} questions");













void StartOrEnd(string isPlaying)
{
    if (isPlaying.ToString() == "n")
    Console.WriteLine("Goodbye!");
    Environment.Exit(0);

    

}

//while (isPlaying.ToLower() == "y")
//{
//    // Your code here
//    Console.WriteLine("What 2 numbers added together equal 176");
//    Console.WriteLine("Please enter a number: ");
//    int number1 = Convert.ToInt32(Console.ReadLine());

//    Console.WriteLine($"Time left {DateTime.Now} ");

//    // Pause for 1 second
//    Thread.Sleep(1000);
//}