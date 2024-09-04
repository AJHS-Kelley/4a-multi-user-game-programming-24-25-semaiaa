//Data Types and Operators, Semaia Encalade, v0.0
using System;
class DataTypeOperators {
  static void Main() {
  }}
    //This is a comment, it gets ignored.

    /*
    /*This is still a comment.
    */
  
    // DATA TYPES
    // C# is STATICALLY TYPED -- once a veriabale has a data type, it cannot change. 

    // Float - float -- decimal numbers, t/- including 0.0

    // Double - double -- decimal numbers, t/- including 0.0 <-- MOST COMMONLY USED DECIMAL

    // Integers -- int -- whole numbers, t/-, including 0

    // VARIABLES ARE 'BUCKETS' WITH A NAME TO STORE DATA INSIDE

    // DECLARING (CREATING VARIABLES)
    // Method #1 -- Declared But Not Assign
    // ataType variableName; 

    int myInteger; 
    double myDouble; 

    // Method #2 -- Declare AND Assign

    int myInteger2 = 1;
    double myDouble2 = 2.05; 

    /Strings -- Collections of letters, numbers, specical charecters. 
    string myString = "This is my string" 

    // Boolean -- bool - True or False Values
    bool myBool = true; 
    bool fireResistance = true;
    bool hasPurpleKey = false; 

    // Character -- char -- a single character. 
    char myChar = 'A'

    //ASSIGNING VALUES AFTER DECLERATION

    myInteger = 5; 
    myInteger = -1.0D; 

    // PRINTING VARIABLES TO THE CONSOLE TERMINAL
    Console.WriteLine (myInteger); 
     Console.WriteLine (myDouble); 

     // PRINTING EXPRESSIONS TO THE CONSOLE TERMINAL
    Console.WriteLine (myInteger - 25); 
     Console.WriteLine (myDouble +2.5D); 

    // PRINTING VARIABLES TO THE CONSOLE TERMINAL
    Console.WriteLine (myInteger); 
     Console.WriteLine (myDouble); 

     // OPERATORS -- ARITHMETIC
     int myNewInt = myInteger 

     // Addition 
     int myNewInt = myInteger + myInteger2; 
     double myNewDouble = myNewDouble = myDouble2
     double myNewNumber = myIntger + myDouble; 

     // SUBTRACTION 
     myNewNumber =  myDouble - myIntger; 

     // DIVISON 
     myNewNumber = myDouble / myIntger; 
     
     // MULTIPLICTION myNewNumber = myDouble = myIntger 

     // MOUDLUS -- Divides, then returns the REMAINDER 
     // Most commonly used to determine EVEN or ODD 
     myNewNumber = myDouble %2; 
     
     int students = 6; 
     int numSlices = 35; 
     intLeftovers; 

     leftOvers = numSlices% students; 

     // Increment / Decrement -- Most Fequently used in LOOPS
     int x = 0; 
     X++; // What is x equal to now?
     // increment ++ adds 1 to the current value and puts the new value into the bucket
     X--; 
     Decrement -- substracts 1 more from the current value and puts the new value into the bucket 

     // Special Assignment Ooperators 
     X += 1; 
     X *= 1; 
     X /= 1; 
     X -= 1; 
     X %= 1; 
     // Take current value, perform the calculation, put new value into bucket

     // COMPARISON OPERATORS
     // EVALAUATE THE EXPRESSION, RETURN true OR false 
     int y =5; 
     int z = 3; 

     // IS-EQUAL-TO == is the value on the left not equa; to the right?
     Console.WriteLine(y == z); 

     // NOT-EQUAL-TO != is the value on the left not equa; to the right?
     Console.WriteLine(y != z);

     // GREATER THAN >
     Console.WriteLine(y > z);
     // GREATER-THAN-OR-EQUAL-TO >=
     Console.WriteLine(y >= z);
     // LESS THAN < 
     Console.WriteLine(y < z);
     // LESS THAN-OR-EQUAL-TO <=
     Console.WriteLine(y <= z);

     // LOGICAL OPERATORS 
     int b = 1; 
     double c = 2.0D; 
     string favColor = "Blue";
     // Logical AND && -- all statements must be True
     Console.WriteLine( b > 1 && c != 5.0D); // false because b is not 
     Console.WriteLine( b == 1 && c < 10.0D); // both are true; whole expression is true 
     // If one expression is most likely to be False, check for it FIRST! 
     Console.WriteLine(hasPurpleKey == true && playerLevel > 5)

     // Logical OR || -- ONE statement must be true
     Console.WriteLine( b > 1 || c != 5.0D); // true because c is not equal to 5.0
     Console.WriteLine( b == 2 || c > 10.0D); // false because both expressions are false 
     //Cheack for the statement most likely to be true first! 
     Console.WriteLine(hasBlueKey == true && playerLevel > 3)

     // Logiical NOT ! -- Returns the opposite value of the expression 
     Console.WriteLine(b > -1); // True 
     Console.WriteLine(!(b > -1)); // False

     // READIMG USER INPUT FROM THE CONSOLE / TERMINAL

    Console.WriteLine("What is your player name? Type it and press ENTER.\n")

    // CREATE A VARIABLE TO STORE THE DATA, 
    string playerName = Console.ReadingLine();
    // Console.ReadLine() ONLY RETURNS string data types. 
    string playerName = Console.ReadLine(); 
    Console.WriteLine (age + age);  
    // Adding string data types together is called CONCATENATION

    // PRINT VARIABLE TO THE SCREEN 
    Console.WriteLine("Your player name is" + playerName);

    // INPUTTING NUMBERS FROM THE CONSOLE. 

    Console.WriteLine("How much many chicken nuggs can you eat in 5 minutes? Enter an integer value and press enter.\")
    int numNuggs = Convert.ToInt32(ConsoleReadLine());
    Console,WriteLine(numNuggs + numNuggs);


