﻿class CheckersChallenges
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
        public Position Pos;
    }

    // We expect to work with 2D coordinates a lot in our board games,
    // so we create a custom data type to hold these.
    struct Position
    {
        public int X, Y;

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }

    /*
     * [ ][ ][ ] 
     * [ ][ ][ ]
     * [ ][ ][ ]
     */

    public static void Run()
    {
        // "const" = "constant". This keyword restricts this variable
        // from being changed after its initial value is set.
        // This is nice to do, as the board size does not change in neither
        // checkers nor chess.
        const int boardSize = 8;

        Piece piece = new Piece();

        while (true)
        {
            Console.Clear();

            for (int y = 0; y < boardSize; y++)
            {
                // Print each tile in the row.
                for (int x = 0; x < boardSize; x++)
                {
                    // Check if our piece is sitting on the tile we are
                    // about to draw. If it is, draw an X inside the tile.
                    // Otherwise, draw the tile as normal.
                    if (x == piece.Pos.X && y == piece.Pos.Y)
                    {
                        Console.Write("[X]");
                    }
                    else
                    {
                        Console.Write("[ ]");
                    }
                }

                // Print out a newline to skip to a new row.
                Console.WriteLine();
            }

            while (!Console.KeyAvailable) { }

            ConsoleKey key = Console.ReadKey(true).Key;

            // Create a variable to store where we are *requesting* our piece
            // to move. We initialize it to be the piece's current position,
            // since all moves will be offsets from where it currently is.
            Position targetPosition = piece.Pos;

            // If we are attempting an input, increment the target position appropriately.
            if (key == ConsoleKey.UpArrow)
                targetPosition.Y -= 1;
            else if (key == ConsoleKey.DownArrow)
                targetPosition.Y += 1;
            else if (key == ConsoleKey.LeftArrow)
                targetPosition.X -= 1;
            else if (key == ConsoleKey.RightArrow)
                targetPosition.X += 1;

            // Check if the target position is within the bounds of the board.
            // (i.e., not negative and below the size of the board).
            if (targetPosition.X >= 0 && targetPosition.X < boardSize
                && targetPosition.Y >= 0 && targetPosition.Y < boardSize)
            {
                piece.Pos = targetPosition;
            }
        }
       
    }
}

