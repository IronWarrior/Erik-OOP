﻿class Program
{
    private static void Main()
    {
        // string course = ".-----.-----......-----";

        // char[] chars = { 'A', 'B', 'C' };

        //int i = 0;

        //while (i < course.Length)
        //{
        //    Console.Write(course[i]);
        //    i++;
        //}

        //for (int i = 0; i < course.Length; i++)
        //{
        //    if (i == 2)
        //    {
        //        Console.Write("A");
        //    }
        //    else
        //    {
        //        Console.Write(course[i]);
        //    }
        //}

        string sentence = "The quick brown fox jumps over the lazy dog";

        while (true)
        {
            Console.WriteLine("Enter a character to replace with X");
            char c = Console.ReadLine()[0];

            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == c)
                {
                    Console.Write("X");
                }
                else
                {
                    Console.Write(sentence[i]);
                }
            }

            //string newSentence = sentence.Replace(c, "X");

            //for (int i = 0; i < newSentence.Length; i++)
            //{
            //    Console.Write(newSentence[i]);
            //}
        }

        //for (int i = 0; i < sentence.Length; i++)
        //{
        //    Console.Write(sentence[i]);
        //    Thread.Sleep(50);
        //}

        //foreach (char c in sentence)
        //{
        //    Console.Write(c);
        //    Thread.Sleep(50);
        //}

        //Console.Clear();

        //while (true)
        //{
        //    Console.WriteLine("Hello!");
        //    Thread.Sleep(500);
        //}

        //Console.WriteLine(course);
    }

    private static void ComposerExploration()
    {
        // To block comment, select all the code you want commented,
        // press CTRL-K, C
        // To uncomment, CTRL-K, U

        List<string> compositionNotes = new List<string>();
        List<string> compositionDurations = new List<string>();

        compositionNotes.Add("D#");  // 250
        compositionDurations.Add("1/4");

        compositionNotes.Add("A");   // 500
        compositionDurations.Add("1/2");

        compositionNotes.Add("C");   // 250
        compositionDurations.Add("1/4");

        string enteredNote = compositionNotes[2];
        string enteredDuration = compositionDurations[2];

        int frequency = 0;

        if (enteredNote == "C")
        {
            frequency = 277;
        }
        else if (enteredNote == "D")
        {
            frequency = 293;
        }

        Console.Beep(frequency, 500);
    }

    private static void Challenge_8_9_10()
    {
        List<int> numbers = new List<int>();

        while (true)
        {
            Console.WriteLine("Please enter a number.");
            int input = int.Parse(Console.ReadLine());

            numbers.Add(input);

            int i = 0;

            Console.WriteLine("Your numbers are...");

            while (i < numbers.Count)
            {
                Console.WriteLine(numbers[i]);

                i++;
            }

            Console.WriteLine();

            // Ask the user if they want a sum or product.
            Console.WriteLine("Do you want a sum or product?");

            string operation = Console.ReadLine();

            int result = 0;

            if (operation == "sum")
            {
                result = 0;
            }
            else if (operation == "product")
            {
                result = 1;
            }

            i = 0;

            while (i < numbers.Count)
            {
                if (operation == "sum")
                {
                    result += numbers[i];
                }
                else if (operation == "product")
                {
                    result *= numbers[i];
                }

                i++;
            }

            Console.WriteLine($"The sum of all numbers entered is: {result}");
        }
    }

    private static void Lesson3()
    {
        //int num0 = 0;
        //int num1 = 2;
        //int num2 = 49;
        //int num3 = 3;

        //Console.WriteLine(num0);
        //Console.WriteLine(num1);
        //Console.WriteLine(num2);
        //Console.WriteLine(num3);

        //for (int i = 0; i < 4; i++)
        //{
        //    if (i == 0)
        //        Console.WriteLine(num0);
        //    else if (i == 1)
        //        Console.WriteLine(num1);
        //}

        List<int> numbers = new List<int>();
        numbers.Add(15);    // 0
        numbers.Add(77);    // 1
        numbers.Add(49);    // 2
        numbers.Add(16);    // 2
        numbers.Add(11);    // 2
        numbers.Add(77);    // 2

        int i = 0;

        numbers.RemoveAt(2);

        while (i < numbers.Count)
        {
            Console.WriteLine(numbers[i]);

            i++;
        }
    }

    private static void Lesson2()
    {
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

        //Console.WriteLine("Please enter a name and a number.");

        //string name = Console.ReadLine();
        //int number = int.Parse(Console.ReadLine());

        //int i = 0;

        //while (i < number)
        //{
        //    Console.WriteLine(name);

        //    i++;
        //}
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