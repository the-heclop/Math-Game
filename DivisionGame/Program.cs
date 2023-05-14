using DivisionGame;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
 

Random random = new Random();


Console.WriteLine("This is a math game, see if you can guess the right answer in time");
Console.WriteLine("Try to solve the problems");
Console.WriteLine("Would you like to play y/n");
string isPlaying = Console.ReadLine();

StartOrEnd(isPlaying);

Console.WriteLine("How many rounds would you like to play");
int numOfGames = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("WHich operation of math would you like to use? Please choose: + - / *");
string operation = Console.ReadLine();

Stopwatch timer = new Stopwatch();
timer.Start();

for (int i = 0; i < numOfGames; i++)
{
    int num1 = random.Next(1, 100);
    int num2 = random.Next(1, 100);
    int answer = 0;
    int round = i+1;
    

    switch (operation)
    {
        case "+":
            answer = num1 + num2 ;
            break;
        case "-":
            answer = num1 - num2;
            break;
        case "/":
            answer = num1 / num2;
            break;
        case "*":
            answer = num1 * num2;
            break;
        default:
            Console.WriteLine("Please choose a valid operation");
            break;
    }


    

    Console.WriteLine($"What is {num1} {operation} {num2} ");
    int userAnswer = Convert.ToInt32(Console.ReadLine());

    List<GameHistoryModel> gameHistory = new List<GameHistoryModel>();
    gameHistory.Add(new GameHistoryModel { answer = answer, userAnswer = userAnswer, rounds = round });

    if (answer == userAnswer)
    {
        Console.WriteLine($"Correct! the answer is {answer}");
    }
    
    Console.WriteLine("Sorry incorrect answer ");
    


    foreach (var item in gameHistory)
    {
        Console.WriteLine($"The correct answer was {item.answer} your answer was {item.userAnswer} in round {item.rounds} ");
    }

}



timer.Stop();


Console.WriteLine($"You took {timer.Elapsed.TotalSeconds} seconds to answer {numOfGames} questions");


















void StartOrEnd(string isPlaying)
{
    if (isPlaying.ToString() == "n")
    {
        Console.WriteLine("Goodbye!");
        Environment.Exit(0);

    }
    else if (isPlaying.ToString() == "y")
        Console.WriteLine();
}

