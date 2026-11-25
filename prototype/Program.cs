using System.Runtime.CompilerServices;
using System.Transactions;

public class Program
{
    public static void Main(string[] args)
    {
        int[,] chessboard = {{0,0,0,0,0,0,0,0},{0,0,0,0,0,0,0,0},{0,0,0,0,0,0,0,0},{0,0,0,0,0,0,0,0},{0,0,0,0,0,0,0,0},{0,0,0,0,0,0,0,0},{0,0,0,0,0,0,0,0},{0,0,0,0,0,0,0,0}};
        chessboard[3,5] = 1;

        bool quit = false;
        string validrows = "abcdefgh";
        string validcols = "12345678";

        printChessboard(chessboard);
        while (!quit)
        {
            Console.Write("Enter Move, or press Q to quit: ");
            string move = Console.ReadLine();
            move = move.ToLower();

            if (move == "q")
            {
                break;
            }
            else if (move.Length != 2)
            {
                Console.WriteLine("Invalid move - bad character count.");
            }
            else if (!validrows.Contains(move[0]) || !validcols.Contains(move[1]))
            {
                Console.WriteLine("Invalid move - " + move + " is not a legal square");
            }
            else
            {
                int[] newSquare = parseMove(move);
                chessboard = moveKnight(newSquare);
                printChessboard(chessboard);
            }
        }
    }

    public static int[] parseMove(string move)
    {
        string rows = "abcdefgh";
        string cols = "12345678";

        int row = rows.IndexOf(move[0]);
        int col = cols.IndexOf(move[1]);
        return [row,col];
    }

    public static int[,] moveKnight(int[] square)
    {
        // doing it this way so i can black out already-visited squares later
        int[,] output = {{0,0,0,0,0,0,0,0},{0,0,0,0,0,0,0,0},{0,0,0,0,0,0,0,0},{0,0,0,0,0,0,0,0},{0,0,0,0,0,0,0,0},{0,0,0,0,0,0,0,0},{0,0,0,0,0,0,0,0},{0,0,0,0,0,0,0,0}};
        output[square[0], square[1]] = 1;
        return output;
    }

    public static void printChessboard(int[,] chessboard)
    {
        bool squareParity = true;
        string rows = "abcdefgh";

        Console.WriteLine("  1 2 3 4 5 6 7 8");

        for(int i = 0; i < 8; i++)
        {
            Console.Write(rows[i] + " ");
            for(int j = 0; j < 8; j++)
            {
                if(chessboard[i,j] == 0)
                {
                    if (squareParity)
                    {
                        Console.Write("□ "); 
                        squareParity = false;
                    }
                    else
                    {
                        Console.Write("■ "); 
                        squareParity = true;
                    }
                }
                if(chessboard[i,j] == 1)
                {
                    Console.Write("♞ ");
                    squareParity = !squareParity;
                }
            }
            squareParity = !squareParity;
            Console.Write("\n");
        }
    }
}
