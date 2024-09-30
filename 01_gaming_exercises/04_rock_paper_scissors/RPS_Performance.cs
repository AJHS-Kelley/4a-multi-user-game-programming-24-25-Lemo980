// CODE CHECKED, ALL GOOD! 
using System;

class RPS {
    static void Main(){
    
    string CPUchoice = "";
    string userChoice = "";
    int playerPts = 0;
    int compPts = 0;
    int numDraws = 0;


    //GAME LOOP
    int loopCount = 0;
    int loopReqs = 0;

    Console.WriteLine("How many loops would you like? Please input an integer then press ENTER.\n ");
    loopReqs = Convert.ToInt32(Console.ReadLine());


while(loopCount < loopReqs)
{
    Random rnd = new Random();
    int CPUrand = rnd.Next(1, 3);
    int playerRand = rnd.Next(1,3);
    //Console.WriteLine(CPUrand);

    if (CPUrand == 1)
    {
        CPUchoice = "rock";
    }
    else if (CPUrand == 2)
    {
        CPUchoice = "paper";
    }
    else
    {
        CPUchoice = "scissors";
    }

    if (playerRand == 1)
    {
        userChoice = "rock";
    }
    else if (playerRand == 2)
    {
        userChoice = "paper";
    }
    else
    {
        userChoice = "scissors";
    }
    //Console.WriteLine(CPUchoice);

    //If there is a draw
    if (CPUchoice == userChoice)
    {
        numDraws++;
    }
    //Checks for what the CPU chose then compares it to user choice and adds points accordingly
    else if(CPUchoice == "rock")
    {
        if(userChoice == "paper")
        {
            playerPts = playerPts + 1;

        }

        else
        {
            compPts = compPts + 1;
        }
    }

    else if(CPUchoice == "paper")
    {
        if(userChoice == "scissors")
        {
            playerPts = playerPts + 1;
        }

        else
        {
            compPts = compPts + 1;
        }
    }

    else if(CPUchoice == "scissors")
    {
        if(userChoice == "rock")
        {
            playerPts = playerPts + 1;
        }

        else
        {
            compPts = compPts + 1;
        }
    }
        userChoice = "";

    loopCount++;
}
    Console.WriteLine($"Player score: {playerPts}");
    Console.WriteLine($"CPU score: {compPts}");
    Console.WriteLine($"Draws: {numDraws}");
    }
}