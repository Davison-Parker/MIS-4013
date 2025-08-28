//data_type variable_name = value
Random r = new Random();

//Generates random value between 1 and 5; max = value + 1
int rand = r.Next(1, 5 + 1);
Console.WriteLine($"Generated a random number with the value {rand}.");
//Console.WriteLine("Generated a random number with the value " + rand + ".");

int guess;
int count = 0;

do
{
    Console.WriteLine("Guess a number between 1 and 5.");
    string userGuess = Console.ReadLine();
    //int guess = Convert.ToInt32(userGuess);
    guess = int.Parse(userGuess);
    count++;

    Console.WriteLine($"You guessed {userGuess}.");

    //if (rand == guess) 
    //{
    //    Console.WriteLine("You guessed correctly!");
    //}
    //else
    //{
    //    Console.WriteLine("You guessed incorectly.");
    //}

    if ( rand != guess )
    {
        if (guess > rand)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Your guess was too high.");
            Console.ForegroundColor = ConsoleColor.White;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Your guess was too low.");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

} while (rand != guess);

Console.WriteLine($"You guessed correctly after {count} guesses");