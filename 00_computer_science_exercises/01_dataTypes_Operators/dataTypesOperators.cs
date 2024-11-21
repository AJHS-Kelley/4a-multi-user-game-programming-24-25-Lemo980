// data types and operators, Eliot Blanton, v0.0
using system;

class DataTypesOperators{
    static void Main(){
    //This is a comment
    /* 
    this is still a comment
    */
    //DATA TYPES
    //C# is statically typed -- once a variablke has a data type, it cannot change

    //Float - float -- decimal numbers, +/- including 0.0
    //Double - double - decimal numbers, +/-, including 0.0
    //Integers -- int -- whole numbers, +/-, including 0

    //variables are 'buckets' with a name to store data inside

    //declaring (creating variables)

    // method #1 declared but not assigned
    // dataType variableName;
    int myInteger;
    double myDouble;

    //Method #2 -- declare and assign
    int myInteger2 = 1;
    double myDouble2 = 2.05D;

    //strings -- Collections of letters, numbers, special characters
    string myString = "This is my string.";

    //Boolean -- bool - True or False values
    bool myBool = true;
    bool fireResistance =true;
    bool hasPurpleKey = false;






















































    //special assignment operators
    x += 1;
    x *= 1;
    x /= 1;
    x -= 1;
    x %= 1;
    //take current value, perform calculation, put new value into bucket

    //compairison operators
    //evaluate the expression, return true or false
    int y = 5;
    int z = 3;

    // //IS-EQUAL
    // Console.WriteLine(y == z);

    // //NOT-EQUAL-TO != is the value on the left not equal to the right?
    // Console.WriteLine(y != z);

    // //Greater than >
    // Console.WriteLine(y > z);

    // //greater than or equal to >=
    // Console.WriteLine(y >= z);

    // //less than <
    // Console.WriteLine(y < z);

    // //less than or equal to <=
    // Console.WriteLine(y <= z);

    // Logical operators

    int b = 1;
    double c = 2.0D;
    string favColor = "Blue";
    
    // //logical and && -- all statements must be true
    // Console.WriteLine(b > 1 && c != 5.0D); //false as b is not greater than one
    // Console.WriteLine(b == 1 && c < 10.0D); // both true, whole statement is true
    // // if one expression is more likely to be false, check for it first
    // Console.WriteLine(hasPurpleKey == true && playerLevel > 5);

    // //Logical or || -- One statement must be true
    // Console.WriteLine(b > 1 || c != 5.0D); //true as c is not equal to 5.0D
    // Console.WriteLine(b == 2 || c > 10.0D); // both false, whole statement is false
    // //Check for most likely to be true first
    // Console.WriteLine(hasBlueKey == true && playerLevel > 3);

    //Logical not ! -- returns the opposite of the expression
    Console.WriteLine(b > -1) //True
    Console.WriteLine(!(b > -1)); //False

    // Reading user input from the console
    Console.WriteLine("What is your player name? Type it and press ENTER \n");

    //Create a variable to store the data
    string playerName = Console.ReadLine();
    Console.WriteLine("What is your age? Type it and press ENTER \n");
    string age = Console.ReadLine();
    Console.WriteLine(age + age);
    //Adding strings together is called concatenation
    //Print the variable to the screen
    //Console.WriteLine("Your age is" + age);

    //inputing numbers from the console
    Console.WriteLine("How many chicken nuggies can you eat in 5 minutes? Enter an integer value and press ENTER \n")
    int numNuggies = Convert.ToInt32(Console.ReadLine());
    console.WriteLine(numNuggies + numNuggies);

    }
}