using System;
class RockPaperSissors {
  static void Main() {
    // PLAYER VARIABLES
    string playerName = "Test Player";
    int playerScore; 
    string playerChoice; 

    // CPU VARIABLES
    int cpuScore; 
    string cpuChoice; 

    Console.WriteLine("Welcome to the Rock, Paper Sissors Bot!\n"); 
    Console.WriteLine("Please type your name and press Enter.\n");
    playerName =Consolew.ReadLine(); 
    Console.WriteLine($"Hello {playerName0}. Is that correct?\n"); 
    Console.WriteLine("Please type yes or no, then press enter.\n")
    string isCorrect = Console.ReadLine(). ToLower(); 

    if (isCorrect == "yes")
    {
      Console.WriteLine($"Great! I'll call you {playerName}.\n")
    }
    else if (isCorrect == "no")
    {
      Console.WriteLine("Please type your name and press ENTER.\n")
      playerName = Console.ReadLine();
    }
    else{
      Console.WriteLine("Unable to determine your answer. Try Again.\n")
    }




    Console.WriteLine("""
    +================================================================================================+
    |                                                                                                |
    |                      WELCOME TO THE ROCK, PAPER, SCISSORS CHALLENGE!                           |
    +================================================================================================+
    You will select from Rock, Ppaer or Scissors. 
    The CPU will select one of those choices at random. 
    Then a winer will be determind using the following rules: 
    -- Rock Beats Scissors 
    -- Paper Beats Rock
    -- Scissors Beats Paper

    The winner will receive a point. 
    The first player to score 5 points will be declared the winner. 
    """)


    while (playerScore < 5 && cpuScore < 5)
    // Print the scores. 
    Console.WriteLine($"Your Score: {playerScore}\nCPU Score: {cpuScore}\n"); 

    // Allow player to select R, P, S. 
    Console.WriteLine("Please choose rock, paper, or scissors.  Type your answer and press ENTER\n.")
    playerChoice = Console.ReadLine().ToLower(); 
    if (playerChoice is "rock" and playerChoice != "paper"\n.); 
    {
      Console.WriteLine("Please choose rock, papaer, or scissors. Type your answer and press ENTER\n.")
    }

    // Allow CPU to select randomly. 
    // Compare the two other choices and determine a winner. 
    // Output the results to the screen.
    // Give winner a point




  }}
  

    
