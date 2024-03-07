class CheckersChallenges
{
    // CHECKERS
    /* "Board" N x N grid 
     * "Pieces" 
     *  - Color (Team)
     *  - Position (x, y)
     *  A piece can...
     *  - Move
     *      - Diagonally
     *          - To an empty adjacent (next-to) square
     *          - Can't move off the board
     *          - They can move two squares if there is an enemy
     *            piece in the way.
     *      - Jump to capture
     *  - Capture
     */

    class Piece
    {
        public int X, Y;

        public override string ToString()
        {
            return $"{X}, {Y}";
        }
    }

    /*
     * [ ][ ][ ] 
     * [ ][ ][ ]
     * [ ][ ][ ]
     */

    public static void Run()
    {
        Piece piece = new Piece();

        //while (true)
        //{
        //    while (!Console.KeyAvailable) { }

        //    ConsoleKey key = Console.ReadKey(true).Key;

        //    if (key == ConsoleKey.UpArrow)
        //        piece.Y += 1;
        //    else if (key == ConsoleKey.DownArrow)
        //        piece.Y -= 1;
        //    else if (key == ConsoleKey.LeftArrow)
        //        piece.X -= 1;
        //    else if (key == ConsoleKey.RightArrow)
        //        piece.X += 1;

        //    Console.WriteLine(piece);
        //}

        int boardSize = 3;

        for (int y = 0; y < boardSize; y++)
        {
            // Print each tile in the row.
            for (int x = 0; x < boardSize; x++)
            {
                Console.Write("[ ]");
            }

            // Print out a newline to skip to a new row.
            Console.WriteLine();
        }
    }
}

