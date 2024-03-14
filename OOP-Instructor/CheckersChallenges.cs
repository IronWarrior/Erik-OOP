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
        public Vector2 Pos;
        public char Glyph;

        public Piece(char glyph)
        {
            Glyph = glyph;
        }
    }

    // We expect to work with 2D coordinates a lot in our board games,
    // so we create a custom data type to hold these.

    /*
     * [ ][ ][ ] 
     * [ ][ ][ ]
     * [ ][ ][ ]
     */

    public static void Run()
    {
        // Operator overloading example.
        //Position posA = new Position(5, 12);
        //Position posB = new Position(1, 2);

        //Position posC = posA + posB;

        //Console.WriteLine(posC);

        // "const" = "constant". This keyword restricts this variable
        // from being changed after its initial value is set.
        // This is nice to do, as the board size does not change in neither
        // checkers nor chess.
        const int boardSize = 8;

        Piece player = new Piece('P');
        Piece enemy = new Piece('E');
        enemy.Pos = new Vector2(5, 5);

        List<Piece> pieces = new List<Piece>();

        pieces.Add(player);
        pieces.Add(enemy);

        while (true)
        {
            Console.Clear();

            for (int y = 0; y < boardSize; y++)
            {
                // Print each tile in the row.
                for (int x = 0; x < boardSize; x++)
                {
                    bool isOccupied = false;

                    Console.Write("[");

                    // Check if our piece is sitting on the tile we are
                    // about to draw. If it is, draw an X inside the tile.
                    // Otherwise, draw the tile as normal.
                    foreach (Piece piece in pieces)
                    {
                        if (piece.Pos == new Vector2(x, y))
                        {
                            Console.Write(piece.Glyph);

                            isOccupied = true;
                            break;
                        }
                    }

                    if (isOccupied == false)
                    { 
                        Console.Write(" ");
                    }

                    Console.Write("]");
                }

                // Print out a newline to skip to a new row.
                Console.WriteLine();
            }

            while (!Console.KeyAvailable) { }

            ConsoleKey key = Console.ReadKey(true).Key;

            // Create a variable to store where we are *requesting* our piece
            // to move. We initialize it to be the piece's current position,
            // since all moves will be offsets from where it currently is.
            Vector2 direction = Vector2.Zero;

            // If we are attempting an input, increment the target position appropriately.
            //if (key == ConsoleKey.UpArrow)
            //    targetPosition.Y -= 1;
            //else if (key == ConsoleKey.DownArrow)
            //    targetPosition.Y += 1;
            //else if (key == ConsoleKey.LeftArrow)
            //    targetPosition.X -= 1;
            //else if (key == ConsoleKey.RightArrow)
            //    targetPosition.X += 1;

            if (key == ConsoleKey.E)
                direction = new Vector2(1, -1);
            else if (key == ConsoleKey.Q)
                direction = new Vector2(-1, -1);
            else if (key == ConsoleKey.Z)
                direction = new Vector2(-1, 1);
            else if (key == ConsoleKey.C)
                direction = new Vector2(1, 1);

            // Did the user enter in a direction at all?
            if (direction != Vector2.Zero)
            {
                Vector2 targetPosition = player.Pos + direction;

                // Check if the target position is within the bounds of the board.
                // (i.e., not negative and below the size of the board).
                if (targetPosition.X >= 0 && targetPosition.X < boardSize
                    && targetPosition.Y >= 0 && targetPosition.Y < boardSize)
                {
                    Piece occupyingPiece = null;

                    foreach (Piece piece in pieces)
                    {
                        if (piece.Pos == targetPosition)
                        {
                            occupyingPiece = piece;
                            // "break" exits whatever loop you are in.
                            break;
                        }
                    }

                    if (occupyingPiece == null)
                    {
                        player.Pos += direction;
                    }
                    // If the current tile is occupied, capture the piece on the tile,
                    // and then continue one more tile forward in the target direction.
                    else
                    {
                        player.Pos += direction + direction;

                        // Note that we might jump off the board here, if the enemy is at the corner;
                        // TODO: How can we restructure our logic to avoid this?

                        pieces.Remove(occupyingPiece);
                    }
                }
            }
        }       
    }

    // Stub function that could return a piece at the supplied position,
    // if there is no piece, return null.
    private static Piece IsPieceAtTile(Vector2 position)
    {
        return null;
    }

    /*
     * Challenge 20 sub-problems
     * Need to support having multiple pieces on the board
     * Need to be able to remove a piece at will
     * Might be nice to have a function to check if a tile contains a piece, and
     * tell us which piece it contains.
     */
}

