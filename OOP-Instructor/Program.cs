class Program
{
    private static void Main()
    {
        // To block comment, select all the code you want commented,
        // press CTRL-K, C
        // To uncomment, CTRL-K, U

        // GuessingGame();

        // Console.Beep(440, 1000);

        // Print the numbers from 1 to 10.
        //int i = 0;

        //while (i < 10)
        //{
        //    // "Scope"          
        //    i += 1;

        //    Console.WriteLine(i);
        //}

        Console.WriteLine("Please enter a name and a number.");

        string name = Console.ReadLine();
        int number = int.Parse(Console.ReadLine());

        int i = 0;

        while (i < number)
        {
            Console.WriteLine(name);

            i++;
        }
    }

    private static void GuessingGame()
    {
        Console.WriteLine("Please pick an upper bound number.");
        int upperBound = int.Parse(Console.ReadLine());

        Random rand = new Random();

        int randomNumber = rand.Next(1, upperBound);

        while (true)
        {
            Console.WriteLine("Please guess a number!");

            int guess = int.Parse(Console.ReadLine());

            if (guess == randomNumber)
            {
                Console.WriteLine("You won!");
                break;
            }
            else if (guess < randomNumber)
            {
                Console.WriteLine("Too low!");
            }
            else if (guess > randomNumber)
            {
                Console.WriteLine("Too high!");
            }
        }
    }
}