using System;

class Template {
    static void Main(){
    
    //Declaring variables
    string CPUchoice = "";
    string userChoice = "";
    string userName = "Test player";
    int playerPts = 0;
    int compPts = 0;
    string botActive = "";

    //get users name and describe game rules
    Console.WriteLine("To start, input your name and press ENTER.");
    userName = Console.ReadLine();
    Console.WriteLine("Welcome to rock paper scissors " + userName + "!\n");
    Console.WriteLine("In this game two players (you and the CPU) choose rock, paper, or scissors.\nRock beats scissors, scissors beats paper, paper beats rock, and each round win will give you one point.\nFirst to 5 points wins the game!");

    //Choose if you want impossible bot
    while(botActive != "yes" & botActive != "no")
    {
    Console.WriteLine("\n\n\n\nWould you like to lose?\n\n If so, type yes.\n If not, type no");
    botActive = Console.ReadLine().ToLower();
    }

    //continue looping until one side earns 5 points
    while(playerPts < 5 & compPts < 5)
{
    //while the user has not made a valid choice
    while(userChoice != "rock" & userChoice != "paper" & userChoice != "scissors")
    {
    Console.WriteLine("Input rock, paper, or scissors");
    userChoice = Console.ReadLine().ToLower();
    //Console.WriteLine(userChoice);
    }

    //if the bot is active, use this to determine CPUchoice
    if(botActive == "yes")
    {
    if(userChoice == "rock")
    {
        CPUchoice = "paper";
    }
    else if(userChoice == "paper")
    {
        CPUchoice = "scissors";
    }
    else if(userChoice == "scissors")
    {
        CPUchoice = "rock";
    }
    }

    //if the bot is not active, use this to determine CPUchoice
    if(botActive == "no")
    {
    Random rnd = new Random();
    int Rand123 = rnd.Next(1, 4);
    //Console.WriteLine(Rand123);

    if(Rand123 == 1)
    {
        CPUchoice = "rock";
    }
    else if(Rand123 == 2)
    {
        CPUchoice = "paper";
    }
    else
    {
        CPUchoice = "scissors";
    }
    
    //Console.WriteLine(CPUchoice);
    //Console.WriteLine(userChoice);
    }

    //compairing user choice and CPU choice to determine round winner and allocate points

    //If there is a draw
    if(CPUchoice == userChoice)
    {
        Console.WriteLine("Draw. No points have been awarded \n");
    }

    if(CPUchoice == "rock")
    {
        if(userChoice == "paper")
        {
            Console.WriteLine("Congrats " + userName + " you earned a point \n");
            playerPts += 1;
        }

        if(userChoice == "scissors")
        {
            Console.WriteLine("You Lost! The Cpu gains a point\n");
            compPts += 1;
        }
    }

    else if(CPUchoice == "paper")
    {
        if(userChoice == "scissors")
        {
            Console.WriteLine("Congrats " + userName + " you earned a point\n");
            playerPts += 1;
        }

        if(userChoice == "rock")
        {
            Console.WriteLine("You Lost! The Cpu gains a point\n");
            compPts += 1;
        }
    }

    else if(CPUchoice == "scissors")
    {
        if(userChoice == "rock")
        {
            Console.WriteLine("Congrats " + userName + " you earned a point\n");
            playerPts += 1;
        }

        if(userChoice == "paper")
        {
            Console.WriteLine("You Lost! The Cpu gains a point\n");
            compPts += 1;
        }
    }
        //reset userChoice for the next cycle of the loop and print the current standings
        userChoice = "";
        Console.WriteLine("The current standing is \nPlayer: " + playerPts +"\nCPU: " + compPts + "\n");
}

    Console.WriteLine("Game over.");

    //print win/loss message based on which side reached 5 points first
    if(compPts == 5)
{
    Console.WriteLine("The computer has bested you. \nYou are a loser.");
}

    if(playerPts == 5)
{
    Console.WriteLine("You have bested the computer! \nYou are a winner!");
}
    }
}