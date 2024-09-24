// Data Types and Operators, Trinity Way, v0.0
using System;
class DataTypesOperators {
  static void Main() {
 // This is a comment, it gets ignored.
 //pokjasef09ui03412u50-8934u2-54u-


// DATA TYPES
//C# is STATICALLY TYPED -- once a varible has a data type, it cannot change

//Float - float -- decimal numbers, +/= including 0.0

//Double - double -- decimal numbers, +/-, including 0.0 <-- MOST COMMONLY USED DECIMAL

//Integers -- int -- whole numbers, +/-, including 0

// VARIBLES ARE 'BUCKETS' WITH A NAME TO STORE DATA INSIDE

//DECLARING (CREATING VARIBLES)
// Method #1 -- Declared But Not Assigned
//dataType varibleName;

int myInteger;
double myDouble

// Method #2 -- Declare AND Assign
int myInteger2
double myDouble2 = 2.05D;

//Strings -- Collections of letters, numbers, special characters.
string myString = "I like blue cheese.";

//Boolean -- bool - True or False value
bool my Bool =true;
bool fireResistance = false;
bool hasPurpleKey = true;

//Character -- char -- a single character.
char myChar = 'A';

// ASSIGNING VALUES AFTER DECLARATION

myInteger = 5;
myInteger = -1.0D;

//PRINTING VARIABLES TO THE CONSOLE TERMINAL
Console.WriteLine(myInteger);
Console.WriteLine(myInteger);

//PRINTING VARIABLES TO THE CONSOLE TERMINAL
Console.WriteLine(myInteger);
Console.WriteLine(myInteger);

//OPERATORS -- ARITHMETIC

int myNewInt = myInteger + myInteger2;
double myNewDouble = myDouble + myDouble2;

double myNewNumber = myInteger + myDouble;

//Addition
int myNewInt = myInteger + myInteger2;
double myNewDouble = myDouble + myDouble2;
double myNewNumber = myInteger + myDouble;

//SUBTRACTION
myNewNumber = myDouble - myInteger;

//DIVISION
myNewNumber = myDouble / myInteger;

//MULTIPLICATION
myNewNumber = myDouble * myInteger;
// MODULUS --Divides, then returns the REMAINDER
// Most commonly used to determine EVEN or ODD
myNewNumber = myDouble % 2;

int students = 6;
int numSlices = 36;
int leftOvers;

leftOvers = numSlices % students;

//Increments / Decrement -- Most frequently used in LOOPS
int x = = 0;
x++; // What is x equal to now?
// Increment ++ adds 1 to the current value and puts the new value into the bucket
x--;
//Decrement -- subtracts 1 from the current value and puts the new value into bucket

//Special Assignment Operators
x += 1;
x *= 1;
x /= 1;
x -= 1;
x %= 1;
// Take current value, perform the calculation, put new value into bucket

// COMPARISON OPERATORS
// EVALUATE EXPRESSION, RETURN true OR false
int y = 5;
int z = 3;

// IS-EQUAL == is the value on the left equal to the right?
Console.WriteLine(y == z);

// NOT-EQUAL-TO != is the value  on the left is not equal to the right?

// GREATER THAN >
Console.WriteLine( y > z);
// GREATER THAN-OR- EQUAL-TO
Console.WriteLine( y >= z);
// LESS THAN <
Console.WriteLine (y < z);
LESS THAN-OR-EQUAL-TO <=
Console.WriteLine(y <= z);

// LOCIGAL OPERATORS
int b = 1;
double c = 2.0D;
string favColor = "Blue"
// Logical AND && -- all statements must be True
// Console.WriteLine(b > 1 && c != 5.0D); //false because b is not > 1
// Console.WriteLine(b == 1 && c < 10.0D);// both are true, whole expression is true
// // If one expression most likely to be False, check for it FIRST!
// Console.WriteLine(hasPurpleKey == true && playerLevel1 > 5);

Logical OR || -- ONE statement must be True
// Console.WriteLine(b > 1 || c != 5.0D); //true bc c is not equal to 5.0
// Console.WriteLine(b == 2 || c > 10.0D);// false bc both expressions are false
// // Check for the statement most likely to be true first!
// Console.WriteLine(hasBlueKey == true && playerLevel1 > 3);

// Logical NOT ! -- Returns the opposite value of the expression
Console.WriteLine(b > -1);// True
Console.WriteLine(!(b > -1));// False

//READING USER INPUT FROM THE CONSOLE / TERMINAL
Console.WriteLine("What is your player name? Type it and press ENTER.\n");

//CREATE A VARIABLE TO STORE DATA.
string playerName = Console.ReadLine();
//Console.ReadLine()ONLY RETURNS string data types.
string age = Console.ReadLine();
Console.WriteLine(age + age)
//PRINT THE VARIABLES TO THE SCREEN
Console.WriteLine("Your player name is" + playerName);
//Adding string data types together is called CONCATENATION

//PRINT THE VARIBLE TO THE SCREEN
//Console.WriteLine("Your player name is" + playName);

//INPUTTING NUMBERS FROM THE CONSOLE.
Console.WriteLine("How many chicken nuggies can you eat in 5 minutes?");
int numNuggies = Convert.ToInt32(Console.ReadLine();;
Console.WriteLine(numNuggies + numNuggies);


  }
}