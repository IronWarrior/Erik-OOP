class TwentyOneDiscussion
{

    // public static readonly string[] Suits = new string[] { "Hearts", "Spades", "Clubs", "Diamonds" };

    // The identity of a card is:
    // its Suit + Name
    // e.g., "Five of Clubs"
    // Each card also has a score
    enum Suits { Hearts, Spades, Clubs, Diamonds }

    class Card
    {
        public string Name;     // Ace, 2, 6, Jack, etc.
        public Suits Suit;    // 0, 1, 2, 3
        public int Score;       // 1, 2, 6, 10 etc.
        // ...
    }

    // int score;

    class Player
    {
        // Hand or,
        // Collection<Cards>, Name
    }

    class GameState
    {
        // Players, Dealer, Who'sTurn
    }

    class Deck
    {
        // 52 Cards
    }

    class Hand // as in, "Hand of cards"
    {
        // Collection<Card>

        public int Score()
        {
            // for each Card, sum up the score, return the value
            return 0;
        }
    }

    public static void Execute()
    {
        List<Card> deck =
        [
            new Card() { Name = "Ace", Score = 1, Suit = Suits.Hearts },
            new Card() { Name = "Ace", Score = 1, Suit = Suits.Spades },
            new Card() { Name = "Ace", Score = 1, Suit = Suits.Diamonds },
        ];

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 13; j++)
            {

            }
        }
    }
}

