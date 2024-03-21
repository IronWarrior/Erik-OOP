class CheckersSolution
{
    // Contain the entire state of a game of checkers.
    // Whose turn it is.
    // Piece
    // - positions
    // - whether they are captured or not.
    // - whether they are "crowned"
    public enum Players { One, Two }
    public enum Outcomes { One, Two, Draw }
    
    class Checkers
    {
        public Players Turn;
        public List<Piece> Pieces = new List<Piece>();

        private const int boardSize = 8;
        private static readonly char[] boardLetters = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h'];

        public bool AreAnyValidMoves()
        {
            return Pieces.Count <= 2;
        }

        public bool IsGameOver(out Outcomes outcome)
        {
            bool player1HasPieces = false;
            bool player2HasPieces = false;

            foreach (var piece in Pieces)
            {
                if (piece.Player == Players.One)
                {
                    player1HasPieces = true;
                }
                else
                {
                    player2HasPieces = true;
                }
            }

            if (!player1HasPieces && !player2HasPieces)
                throw new Exception("Both players have run out of pieces.");

            if (!player1HasPieces || !player2HasPieces)
            {
                // Game is over, declare a victor.
                outcome = player1HasPieces ? Outcomes.One : Outcomes.Two;

                return true;
            }

            // Otherwise, a stalemate may have occurred.
            bool canStillMove = AreAnyValidMoves();

            if (!canStillMove)
            {
                // Game is over in a stalemate.
                outcome = Outcomes.Draw;

                return true;
            }

            outcome = default;
            return false;
        }

        public string Draw()
        {
            string output = "";

            output += "   ";

            foreach (char letter in boardLetters)
            {
                output += letter;
                output += "  ";
            }

            output += "\n";

            for (int y = 0; y < boardSize; y++)
            {
                output += $"{y + 1} ";

                // Print each tile in the row.
                for (int x = 0; x < boardSize; x++)
                {
                    output += "[";

                    if (IsPieceAtPosition(new Vector2(x, y), out Piece piece))
                    {
                        if (piece.Player == Players.One)
                        {
                            output += "x";
                        }
                        else
                        {
                            output += "o";
                        }
                    }
                    else
                    {
                        output += " ";
                    }

                    output += "]";
                }

                // Print out a newline to skip to a new row.
                output += "\n";
            }

            return output;
        }

        public bool IsPieceAtPosition(Vector2 position, out Piece piece)
        {
            foreach (Piece p in Pieces)
            {
                if (p.Position == position)
                {
                    piece = p;
                    return true;
                }
            }

            piece = default;
            return false;
        }

        public static Vector2 NotationToPosition(string notation)
        {
            char letter = notation[0];
            char number = notation[1];

            int x = Array.IndexOf(boardLetters, letter);
            int y = (int)char.GetNumericValue(number) - 1;

            return new Vector2(x, y);
        }

        public void SetupDefaultPositions()
        {

        }

        public void MovePieceFromTo(Vector2 from, Vector2 to)
        {

        }
    }

    class Piece
    {
        public Vector2 Position;
        public Players Player;

        public Piece(Players player)
        {
            Player = player;
        }
    }

    public static void Run()
    {
        Checkers checkers = new Checkers();

        Piece piece = new Piece(Players.One);
        piece.Position = new Vector2(4, 3);

        Piece piece2 = new Piece(Players.Two);
        piece2.Position = new Vector2(1, 3);

        checkers.Pieces.Add(piece);
        checkers.Pieces.Add(piece2);

        while (true)
        {
            Console.Clear();

            Console.WriteLine(checkers.Draw());

            // example output: "e3 right"
            string input = Console.ReadLine();

            string[] splits = input.Split(" ");

            Vector2 position = Checkers.NotationToPosition(splits[0]);

            if (checkers.IsPieceAtPosition(position, out Piece selected))
            {
                
            }
        }
    }
}

