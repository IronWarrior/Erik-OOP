using System.Numerics;

class Program
{
    private static void Main()
    {

    }

    // World consists of racers and a course.
    class Runner
    {
        public char Glyph;
        public int Position;
    }

    class Race
    {
        public string Course;

        public List<Runner> Runners = new List<Runner>();

        public string Draw()
        {
            string result = "";

            for (int i = 0; i < Course.Length; i++)
            {
                bool isSomeRunnerOnTile = false;

                foreach (Runner runner in Runners)
                {
                    if (runner.Position == i)
                    {
                        result += runner.Glyph;

                        isSomeRunnerOnTile = true;

                        // Exit the foreach loop, but NOT the outer for loop.
                        break;
                    }
                }

                if (isSomeRunnerOnTile == false)
                {
                    result += Course[i];
                }
            }

            return result;
        }

        public void Step()
        {
            Random rand = new Random();

            foreach (Runner runner in Runners)
            {
                char tile = Course[runner.Position];

                float chanceToMoveForwards = 0;

                if (tile == '-')
                {
                    chanceToMoveForwards = 0.25f;
                }
                else if (tile == '.')
                {
                    chanceToMoveForwards = 0.125f;
                }

                float roll = rand.NextSingle();

                if (roll < chanceToMoveForwards)
                {
                    runner.Position += 1;
                }
            }
        }
    }

    private static void RaceMain()
    {
        // "Naive" solution is basically the first one to come
        // to your head without applying any extra thought.
        //string course = "---....---...-----...---";

        //char racer0Glyph = 'A';
        //int racer0Position = 0;

        Runner runnerA = new Runner() { Glyph = 'A' };
        Runner runnerB = new Runner() { Glyph = 'B' };

        Race race = new Race();
        race.Course = "---....---...-----...---";
        race.Runners.Add(runnerA);
        race.Runners.Add(runnerB);

        runnerA.Position = 7;
        runnerB.Position = 12;

        while (true)
        {
            race.Step();

            Console.WriteLine(race.Draw());

            Console.ReadLine();
        }
    }

    struct Vector2
    {
        public float X;
        public float Y;
    }

    class Lifeform
    {

    }

    class Mammal : Lifeform
    {

    }

    class Human : Mammal
    {

    }

    class Lavender : Human
    {

    }

    class Felipe : Human
    {

    }

    class Shape
    {
        public Vector2 Center;
    }

    // Circle
    // float radius
    // circumference?
    //  -- circumference is implicit if you have radius
    // Vector2 center
    class Circle : Shape
    {
        public float Radius;
        
        // public float circumference;

        public float Circumference()
        {
            return (float)(Math.PI * 2 * Radius);
        }
    }

    class Rectangle : Shape
    {
        public float Length, Width;

        public float Area()
        {
            return Length * Width;
        }
    }

    class Square : Shape
    {
        public float Length;

        public float Area()
        {
            return Length * Length;
        }
    }

    class Damageable
    {
        public event Action OnTakeDamage;

        public void TakeDamage()
        {
        }
    }

    private static void Objects()
    {
        //int x;
        //x = 0;

        Vector2 position;
        position.X = 1;
        position.Y = 2;

        // We create a new instance of Circle.
        // An "instance" is an entity that has been
        // instantiated in the "world" and now exists.
        Circle myCircle = new Circle();
        myCircle.Radius = 2;
        myCircle.Center.Y = 1;
        myCircle.Center.X = 1.5f;

        Console.WriteLine(myCircle.Circumference());

        myCircle.Radius = 10000;

        Console.WriteLine(myCircle.Circumference());
    }

    static void FuntionsExamples()
    {
        List<string> list = new List<string>() { "Hello", "Goodbye", "Farewell", "Good day", "Good evening" };

        // PrintList(list);

        string result = CreateStringFromList(list);
        Console.WriteLine(result);

        Console.WriteLine(result == "Hello, Goodbye, Farewell, Good day, Good evening, ");

        //for (int i = 0; i < list.Count; i++)
        //{
        //    Console.WriteLine(list[i]);
        //}

        list.Add("Bonjour");

        Console.WriteLine();
        Console.WriteLine();

        PrintList(list);

        //for (int i = 0; i < list.Count; i++)
        //{
        //    Console.WriteLine(list[i]);
        //}

        list.RemoveAt(0);

        Console.WriteLine();
        Console.WriteLine();

        PrintList(list);

        //for (int i = 0; i < list.Count; i++)
        //{
        //    Console.WriteLine(list[i]);
        //}
    }

    static T CalculateAreaGeneric<T>(T width, T height) where T : INumber<T>
    {
        return width * height;
    }

    static float CalculateArea(float width, float height)
    {
        return width * height;
    }

    static float Average(int[] numbers)
    {
        float sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        float result = sum / numbers.Length;

        return result;
    }

    static void PrintList(List<string> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);
        }
    }

    static string CreateStringFromList(List<string> list)
    {
        string str = "";

        for (int i = 0; i < list.Count; i++)
        {
            str += list[i];
            str += ", ";
        }

        return str;
    }

    private static void ThreadsAndSleep()
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