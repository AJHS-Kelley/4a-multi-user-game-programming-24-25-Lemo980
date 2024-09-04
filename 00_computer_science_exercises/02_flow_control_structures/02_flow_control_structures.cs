using System;

class Template {
    static void Main(){
    
    int day = 1;
    switch (day)
    {
        case 1:
            Console.WriteLine("it's Monday \n");
            break;
        case 2:
            Console.WriteLine("it's Tuesday \n");
            break;
        case 3:
            Console.WriteLine("it's Wednesday \n");
            break;
        //cases 4-6
        case 7:
            Console.WriteLine("it's Sunday \n");
            break;
    }

    // repeating steps over and over again
    //Loops are used to repeat instructions multiple times

    /*While loops are like musical chairs in computer science
    The code will run as long as the condition is true
    Use when you DO NOT know how many loops are needed
    while loop syntax:
    while(conditional expression)
    {
        Code to loop goes here
    }
    */
    /*
    int z = 0;
    while (z < 100)
    {
        Console.WriteLine(z);
        z++;
    }
    
    while (z >= 0)
    {
        Console.WriteLine(z);
        z --;
    }
    */
    /*
    For loops are like playing go fish
    You know how many cards are in your hand
    used when you know how many loops you need ahead of time
    
    for(statement1; statement2; statement3;)
    {
        code to run each time through loop
    }
    statement1 = code to run one time before loop starts
    statement2 = conditional to check after each loop runs
    statement3 = code to run after each loop

    each "trip" through the loop is called an iteration



    counting to 10 with for loops
    */
    
    for(int i = 0; i <= 10; i++)
    {
        Console.WriteLine(i);
    }

    for(int i = 10; i >= 0; i--)
    {
        Console.WriteLine(i);
    }

    //TEST


    }
}