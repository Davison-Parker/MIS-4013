int againC = 1;
int again = 0;

do
{
    Console.WriteLine("Please input the lower bound value.");
    string lowerString = Console.ReadLine();
    int lower = int.Parse(lowerString);

    //try
    //{
    //    lower = int.Parse(lowerString);
    //}
    //catch (FormatException)
    //{
    //    Console.WriteLine("The lower bound value must be an integer.");
    //}
    //catch (OverflowException)
    //{
    //    Console.WriteLine("The lower bound value is too large or too small.");
    //}
    //catch (Exception ex)
    //{
    //    Console.WriteLine($"An error occurred: {ex.Message}");
    //}

    Console.WriteLine("Please input the upper bound value.");
    string upperString = Console.ReadLine();
    int upper = int.Parse(upperString);

    //try
    //{
    //    lower = int.Parse(upperString);
    //}
    //catch (FormatException)
    //{
    //    Console.WriteLine("The lower bound value must be an integer.");
    //}
    //catch (OverflowException)
    //{
    //    Console.WriteLine("The lower bound value is too large or too small.");
    //}
    //catch (Exception ex)
    //{
    //    Console.WriteLine($"An error occurred: {ex.Message}");
    //}

    //data_type variable_name = value
    Random r = new Random();
    //Generates random value between 1 and 5; max = value + 1
    int rand = r.Next(lower, upper + 1);

    Console.WriteLine($"Generated a random number with the value {rand}.");
    //Console.WriteLine("Generated a random number with the value " + rand + ".");

    int guess;
    int count = 0;

    do
    {
        Console.WriteLine($"Guess a number between {lower} and {upper}.");
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

        if (rand != guess)
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

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"You guessed correctly after {count} guesses");
    Console.ForegroundColor = ConsoleColor.White; 

    Console.WriteLine("Would you like to play again? (y/n)");
    string response = Console.ReadLine();
    
if (response == "y")
    {
        again = 1;
    }
    if (response == "n")
    {
        again = 0;
    }

} while (again == againC);

Console.WriteLine("Thank you for playing!");