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
        Console.WriteLine("The greeting has more characters than the goodbye.")
    }
    else
    {
        Console.WriteLine("The goodbye has more characters than the greeting.")
    }

    //Useful String Methods
    Console.WriteLine(greeting.ToUpper) //STRING IS CONVERTED TO FULLY UPPERCASE
    Console.WriteLine(greeting.ToLower) // string is converted to fully lowercase


    }
}