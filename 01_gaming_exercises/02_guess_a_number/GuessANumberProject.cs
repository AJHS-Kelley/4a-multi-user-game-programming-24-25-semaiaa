using System;
class GuessNumber {}
  static void Main() {

  int numGuess = 0; 
  int maxGuess = 8; 
  int guess; 

Random rnd = new Random(); // Create an object named 'rnd' that is a copy of the Random() class. 
 int secretNumber = rnd.Next(100); // Generate from 0 to 99
 Console.WriteLine(secretNumber);

 
  while (numGuess < maxGuess)
  {
    // Console.WriteLine("Secret Number: " + secretNumber)
    Console.WriteLine("Please guess and integer between 1 and 8,\n");
    guess = Convert.ToInt32(Console.ReadLine());  
    // Console.WriteLine("Guess" + guess); 

 numGuess++; 
    if (guess < secretNumber)
    {
      Console.WriteLine("Your guess is too low. \n"); 
    }
    else if (guess > secretNumber) 
    { 
      Console.WriteLine("Your guess is too high. \n");
    }
    else
    {
      Console.WriteLine("Your guessed correctly. \n");
      break; // Keyword to immediately exit a loop.  
    }
      
    if (numGuess >= maxGuess)
    {
      Consonle.WriteLine("You have lost the game, \nMr. Kelly is very disappointed in you.\n");
    }

  }
  }