class CheckersDiscussion
{

    /*
        -state of the pieces
            - positions
            - whether they are alive or not
        - whose turn it is

        "Model" vs. "View"

        The* state*of the game is the * Model *.While the* View* is a way of 
        representing it to the end user.

        This is usually called MVC, or Model View Controller
        (we'll ignore the Controller part for now).
        */

    /*
     * Checkers and Chess similarities
     * Both take place on an 8x8 grid board
     * Both have two players
     * Both have "Pieces", that have some similarities
     * Pieces both have a position, and can make
     * Movements, movement has constraints.
     * Each piece has a different way of moving,
     * But all are restricted in common ways
     * (off the edge of the board, being blocked)
     * Pieces can capture other pieces.
     */

    /* What about chess pieces? How do they differ?
     * Each piece has different permitted movements
     * Some have constraints about which move can capture
     * (pawns can move diagonally and vertically, but only
     * capture diagonally).
     * For chess where scoring matters, each piece is worth
     * a different amount.
     * Each piece has a different visual representation.
     */

    // We have a bunch of objects representing animals.
    // The animals all can MakeNoise(), but the noise
    // differs per animal.

    // e.g., Bears ROAR, Cats meow, Dogs BARK!
    // I want to have a list of animals, then iterate
    // over them and tell them each to MakeNoise();

    // POLYMORPHISM: Things that can be interacted with
    // in a common way from the "outside", but may function
    // differently from the "inside".

    // Polymorphism by COMPOSITION
    //public class Animal
    //{
    //    public string Noise;

    //    public void MakeNoise()
    //    {
    //        Console.WriteLine(Noise);
    //    }
    //}

    // Polymorphism by INHERITENCE
    public abstract class Animal
    {
        public abstract void MakeNoise();
    }

    public class Dog : Animal
    {
        public override void MakeNoise()
        {
            Console.WriteLine("BARK!");
        }
    }

    public class Horse : Animal
    {
        public override void MakeNoise()
        {
            Console.WriteLine("NEIEIGIGH!");
        }
    }

    //public class PokemonType
    //{
    //    public string Name;
    //    public string Type; 
    //}

    //public class Bulbasaur : PokemonType
    //{

    //}

    public static void Run()
    {
        //Animal horse = new Animal() { Noise = "NEIIIGH" };

        //List<Animal> animals =
        //    [
        //        horse,
        //        horse,
        //        horse,
        //    ];

        ////List<Animal> animals =
        ////[
        ////    new Horse(),
        ////    new Horse(),
        ////    new Dog(),
        ////];

        //foreach (Animal animal in animals)
        //{
        //    animal.MakeNoise();
        //}
    }
}

