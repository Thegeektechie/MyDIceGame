        Console.WriteLine("Welcome to the Dice Game!");

        Random random = new Random();

        Console.Write("Enter your user name: ");
        string userName = Console.ReadLine()!;

        int noOfAttempt = random.Next(4, 9);

        Console.WriteLine($"Welcome {userName}, you have {noOfAttempt} number of attempt");

        while (noOfAttempt > 0)
        {
            noOfAttempt = PlayRound(userName, noOfAttempt);

            Console.Write("Do you want to play another round? (y/n): ");

            if (Console.ReadLine()!.ToLower() != "y")
                break;
        }

        Console.WriteLine($"Thank you, {userName}, for playing the Dice Game!");


    static int PlayRound(string userName, int noOfAttempt)
    {
        Console.WriteLine($"You have {noOfAttempt} number of attempt left");
        Console.WriteLine("\nRolling the dice...");

        Random random = new Random();

        int dice1 = random.Next(1, 7);
        int dice2 = random.Next(1, 7);
        int dice3 = random.Next(1, 7);

        Console.WriteLine($"Dice 1: {dice1}");
        Console.WriteLine($"Dice 2: {dice2}");
        Console.WriteLine($"Dice 3: {dice3}");

        int total = dice1 + dice2 + dice3;

        if (dice1 == dice2 && dice2 == dice3)
        {
            int tripleDice = total + 6;
            Console.WriteLine($"Congratulations, you have rolled a triple. Your Total point is: {tripleDice}");
        }
        else if (dice1 == dice2 || dice1 == dice3 || dice2 == dice3)
        {
            int doubleDice = total + 2;
            Console.WriteLine($"Good job!, you have rolled a double. Your Total point is: {doubleDice}");
        }
        else
        {
            Console.WriteLine($"Nice try, your Total point is: {total}");
        }

        return noOfAttempt - 1;
    }