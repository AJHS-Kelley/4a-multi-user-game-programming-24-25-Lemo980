using System;

class Strings {
    static void Main(){
    //in C# ALL STRINGS MUST USE DOUBLE QUOTES "   "

    string greeting = "Hello\n";
    string goodbye = "Goodbye\n";

    // in C# strings are treated like an OBJECT that has properties and methods
    //PROPERTIES -- things that describe the object such as length, values, data types, etc...
    //METHODS -- built in functions related to the object

    //Length is an important property in strings
    Console.WriteLine(greeting.Length);
    Console.WriteLine(goodbye.Length);

    if(greeting.Length > goodbye.Length)
    {
        Console.WriteLine("The greeting has more characters than the goodbye.");
    }
    else
    {
        Console.WriteLine("The goodbye has more characters than the greeting.");
    }

    //Useful String Methods
    Console.WriteLine(greeting.ToUpper()); //STRING IS CONVERTED TO FULLY UPPERCASE
    Console.WriteLine(greeting.ToLower()); // string is converted to fully lowercase

    //string concatenation
    string comboString = greeting + goodbye;
    Console.WriteLine(comboString);

    //string concatenation method #2:
    string comboString2 = string.Concat(greeting, goodbye);
    Console.WriteLine(comboString2);

    //string interpolation -- substituting variables into a string
    string comboString3 = $"My greeting is {greeting}and my goodbye is {goodbye} \n";
    Console.WriteLine(comboString3);

    //string interpolation method #2
    string comboString4 = "My greeting is " + greeting + "and my goodbye is " + goodbye;
    Console.WriteLine(comboString4);

    //Accessing parts of strings
    //Index is a specific location of a character in a string
    //ALL string indexes start at ZERO
    Console.WriteLine(goodbye[0]); // print the character at index 0 (the first character in the string)
    Console.WriteLine(goodbye[4]); // prints the FIFTH character in the list

    //Where is it in my string?
    Console.WriteLine(greeting.IndexOf("l"));

    //Finding parts of a string
    string  fullName = "Billy Mays";
    
    //What Letter?
    int lastInitial = fullName.IndexOf("M");

    //Find the substring
    string lastName = fullName.Substring(lastInitial);

    //Print it
    Console.WriteLine(lastName);





    }
}