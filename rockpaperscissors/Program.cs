// See https://aka.ms/new-console-template for more information


List<string> compChoices = new List<string>{
  "rock", "paper", "scissors"
};

bool playing = true;
int userScore = 0;
int compScore = 0;
int invalidInput = 0;

Console.WriteLine("😀(=^・^=) Welcome to the classic game of Rock, Paper, Scissors. Enter your answer below: (=^・^=)");

do
{

  Random rand = new Random();
  int randomIndex = rand.Next(0, compChoices.Count);
  string compInput = compChoices[randomIndex];
  bool won = false;
  string? userInput = "";
  bool validInput = false;
  do
  {
    userInput = Console.ReadLine();
    if (userInput == "rock" || userInput == "paper" || userInput == "scissors")
    {
      validInput = true;
    }
    else
    {
      Console.WriteLine(@$"you need to take this game seriously. Only choose from the correct options: 'rock', 'paper', or 'scissors'. You only have {invalidInput} tries left");
      invalidInput++;
    }
    if (invalidInput == 3)
    {
      Console.WriteLine("You didn't take this game seriously enough. You have been booted from this game. Try better next time");
      validInput = true;
      playing = false;
    }
  } while (validInput == false);


  if (userInput != null)
  {
    Console.WriteLine(compInput);
    if (userInput == "rock" && compInput == "paper")
    {
      won = true;
    }
    else if (userInput == "paper" && compInput == "rock")
    {
      won = true;
    }
    else if (userInput == "scissors" && compInput == "paper")
    {
      won = true;
    }
    else if (userInput == compInput)
    {
      Console.WriteLine("DRAW!");
    }
    else
    {
      won = false;
      Console.WriteLine("Computer won and you lost");
      compScore++;
      Console.WriteLine(@$"
******** ROCK PAPER SCISSORS ********            
WINS: {userScore}        LOSSES: {compScore} 
*************************************
");
    }

  }
  if (won == true)
  {
    Console.WriteLine("You beat the computer");
    userScore++;
    Console.WriteLine(@$"
******** ROCK PAPER SCISSORS ********            
WINS: {userScore}        LOSSES: {compScore} 
*************************************
");
  }


  if (userScore == 5 || compScore == 5)
  {
    if (userScore == 5)
    {
      Console.ForegroundColor = ConsoleColor.DarkYellow;
      Console.WriteLine("You beat the computer 5 times! WOW!");
      Console.ForegroundColor = ConsoleColor.Gray;

    }
    else
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("The computer is better than you at Rock, Paper, Scissors. Damn...");
      Console.ForegroundColor = ConsoleColor.Gray;

    }
    Console.WriteLine("Play again? y/n");
    string? keepPlaying = "";
    keepPlaying = Console.ReadLine();
    if (keepPlaying == "n")
    {
      playing = false;
    }
    else
    {
      playing = true;
      userScore = 0;
      compScore = 0;
      Console.WriteLine("Welcome to the classic game of Rock, Paper, Scissors. Enter your answer below:");
    }
  }

} while (playing);

