using System;

class RockPaperSissors {
  static void Main() {
    // PLAYER VARIABLES
    string playerName = "Test Player";
    int playerScore = 0;  
    string playerChoice = ""; 

    // CPU VARIABLES
    int cpuScore = 0;
    string cpuChoice ""; 

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
    else
    {
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
    """);



    while (playerScore < 5 && cpuScore < 5)
    // Print the scores. 
    Console.WriteLine($"Your Score: {playerScore}\nCPU Score: {cpuScore}\n"); 

    // Allow player to select R, P, S. 
    Console.WriteLine("Please choose rock, paper, or scissors.  Type your answer and press ENTER\n.")
    
    playerChoice = Console.ReadLine().ToLower(); 
    if (playerChoice is "rock" and playerChoice != "paper"\n.); 
    {
      Console.WriteLine("Please choose rock, papaer, or scissors. Type your answer and press ENTER\n.")
      playerChoice = Console.ReadLine().ToLower();
    }

    // Allow CPU to select randomly. 
    Random rnd = new Random();
 int cpuRand = rnd.Next(0, 2);

 if (cpuRand == 0)
 {
 cpuChoice = "rock";
 }
 else if (cpuRand == 1)
 {
 cpuChoice = "paper";
 }
 else if (cpuRand == 2)
 {
 cpuChoice = "scissors";
 }
 else
 { 
 Console.WriteLine("Unable to determine CPU choice.\n");
 }
 Console.WriteLine("CPU Choice" + cpuChoice);
 
 // Compare the two choices and determine a winner. 
 if (playerChoice == "rock" && cpuChoice == "paper")
 {
 Console.WriteLine($"You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
 Console.WriteLine("The CPU wins.\n");
 cpuScore++;
 }
else if (playerChoice == "rock" && cpuChoice == "scissors")
 {
 Console.WriteLine($"You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
 Console.WriteLine("You win!\n");
 playerScore++;
 }
 else if (playerChoice == "rock" && cpuChoice == "rock")
 {
 Console.WriteLine($"You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
 Console.WriteLine("It's a draw!");
 
 }
 else if (playerChoice == "paper" && cpuChoice == "paper")
 {
 Console.WriteLine($"You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
 Console.WriteLine("It's a draw!");
 
 }
 else if (playerChoice == "paper" && cpuChoice == "scissors")
 {
 Console.WriteLine($"You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
 Console.WriteLine("The CPU wins.\n");
 cpuScore++;
 
 }
 else if (playerChoice == "paper" && cpuChoice == "rock")
 {
 Console.WriteLine($"You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
 Console.WriteLine("You win!\n");
 playerScore++; 
 }
 else if (playerChoice == "scissors" && cpuChoice == "paper")
 {
 Console.WriteLine($"You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
 Console.WriteLine("You win!\n");
 playerScore++; 
 }
else if (playerChoice == "scissors" && cpuChoice == "scissors")
 {
 Console.WriteLine($"You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
 Console.WriteLine("It's a draw!"); 
 }
 else if (playerChoice == "scissors" && cpuChoice == "rock")
 {
 Console.WriteLine($"You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
 Console.WriteLine("The CPU wins.\n");
 cpuScore++; 
 } 
 
 }
 
 if (playerScore > cpuScore)
 {
 Console.WriteLine("Congratulations, you are the winner!\n"); 
 }
 else
 {
 Console.WriteLine("The CPU has defeated you.\n"); 

    // Compare the two other choices and determine a winner. 
    // Output the results to the screen.
    // Give winner a point




  }}
  

    
