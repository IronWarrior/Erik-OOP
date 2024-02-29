namespace TwentyOneSolution
{
    class Program
    {
        enum Suits { Hearts, Diamonds, Clubs, Spades }

        class Card
        {
            public static readonly string[] Names
            = ["Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King"];

            public Suits Suit;
            public int Identity;

            public bool IsAce => Identity == 0;

            public int Score()
            {
                if (Identity >= 9)
                {
                    return 10;
                }
                else
                {
                    return Identity + 1;
                }
            }

            public override string ToString()
            {
                return $"{Names[Identity]} of {Suit} ({Identity}:{Score()})";
            }
        }

        class Deck
        {
            public List<Card> Cards = new();

            public override string ToString()
            {
                string str = "";

                foreach (Card card in Cards)
                {
                    str += $"{card}\n";
                }

                return str;
            }

            // "In-place" shuffle algorithm, that does not require
            // additional data structures to be created (i.e., more lists of cards).
            public void Shuffle()
            {
                Random rand = new();

                for (int i = 0; i < Cards.Count - 1; i++)
                {
                    int swap = rand.Next(i, Cards.Count - 1);

                    Card temp = Cards[i];
                    Cards[i] = Cards[swap];
                    Cards[swap] = temp;
                }
            }

            // Pulling from the back of the deck for performance reasons.
            // (Imagine a queue line of people, when the person at the front leaves,
            // everyone moves up, but if the person at the back were to leave, nobody
            // needs to move).
            public Card Draw()
            {
                Card card = Cards[Cards.Count - 1];

                Cards.RemoveAt(Cards.Count - 1);

                return card;
            }

            // "Builder pattern": using functions to construct
            // complex objects.
            public static Deck BuildStandard()
            {
                Deck deck = new();

                Suits[] suits = Enum.GetValues<Suits>();

                for (int suitIndex = 0; suitIndex < suits.Length; suitIndex++)
                {
                    Suits suit = suits[suitIndex];

                    for (int i = 0; i < 13; i++)
                    {
                        Card card = new()
                        {
                            Identity = i,
                            Suit = suit
                        };

                        deck.Cards.Add(card);
                    }
                }

                return deck;
            }

            public static Deck BuildDummy()
            {
                Deck standard = BuildStandard();

                Deck deck = new();

                for (int i = 0; i < 10; i++)
                {
                    deck.Cards.Add(standard.Cards[i]);
                }

                return deck;
            }
        }

        class Hand
        {
            private readonly List<Card> cards = new();

            public void Insert(Card card)
            {
                cards.Add(card);
            }

            public int CalculateScore()
            {
                int score = 0;

                foreach (Card card in cards)
                {
                    score += card.Score();
                }

                // Additional logic to treat at most once Ace
                // as worth 11, rather than 1, when beneficial
                // to the hand's score.
                foreach (Card card in cards)
                {
                    if (card.IsAce && score + 10 <= 21)
                    {
                        score += 10;
                    }
                }

                return score;
            }

            public override string ToString()
            {
                string str = $"Score {CalculateScore()}: ";

                for (int i = 0; i < cards.Count; i++)
                {
                    str += cards[i];

                    if (i < cards.Count - 1)
                        str += ", ";
                }

                return str;
            }
        }

        static void Main()
        {
            Deck deck = Deck.BuildStandard();

            Hand hand = new Hand();
            hand.Insert(deck.Cards[0]);
            hand.Insert(deck.Cards[0]);
            hand.Insert(deck.Cards[8]);
            // hand.Insert(deck.Cards[9]);

            Console.WriteLine(hand);

            // deck.Shuffle();

            //Console.WriteLine(deck);

            //deck.Draw();
            //deck.Draw();

            //Console.WriteLine();
            //Console.WriteLine(deck);
        }
    }
}
