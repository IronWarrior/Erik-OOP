using System;
using System.Numerics;

class ChessChallenges
{
    class Piece
    {
        public Vector2 Pos;
        public char Glyph;

        public Piece(char glyph)
        {
            Glyph = glyph;
        }
    }


    public static void Run()
    {
        const int boardSize = 8;

        List<Piece> pieces = new List<Piece>();
        List<Vector2> movements = new List<Vector2>();

        Piece player = new Piece('X');


        pieces.Add(player);

        while (true)
        {
            Console.Clear();

            movements.Clear();

            movements.Add(player.Pos + new Vector2(0, 1));
            movements.Add(player.Pos - new Vector2(0, 1));
            movements.Add(player.Pos + new Vector2(1, 0));
            movements.Add(player.Pos - new Vector2(1, 0));

            movements.Add(player.Pos + new Vector2(1, 1));
            movements.Add(player.Pos + new Vector2(-1, 1));
            movements.Add(player.Pos + new Vector2(1, -1));
            movements.Add(player.Pos + new Vector2(-1, -1));

            for (int y = 0; y < boardSize; y++)
            {
                // Print each tile in the row.
                for (int x = 0; x < boardSize; x++)
                {
                    Vector2 currentTile = new Vector2(x, y);

                    bool isOccupied = false;

                    Console.Write("[");

                    // Check if our piece is sitting on the tile we are
                    // about to draw. If it is, draw an X inside the tile.
                    // Otherwise, draw the tile as normal.
                    foreach (Piece piece in pieces)
                    {
                        if (piece.Pos == currentTile)
                        {
                            Console.Write(piece.Glyph);

                            isOccupied = true;
                            break;
                        }
                    }

                    if (!isOccupied)
                    {
                        foreach (Vector2 movement in movements)
                        {
                            if (movement == currentTile)
                            {
                                Console.Write('O');

                                isOccupied = true;
                                break;
                            }
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
            if (key == ConsoleKey.UpArrow)
                direction.Y = -1;
            else if (key == ConsoleKey.DownArrow)
                direction.Y = 1;
            else if (key == ConsoleKey.LeftArrow)
                direction.X = -1;
            else if (key == ConsoleKey.RightArrow)
                direction.X = 1;

            // Did the user enter in a direction at all?
            if (direction != Vector2.Zero)
            {
                player.Pos += direction;
            }
        }
    }
}