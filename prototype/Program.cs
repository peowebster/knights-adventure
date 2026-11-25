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
                parseMove(move);
            }
        }
    }

    public static int[] parseMove(string move)
    {
        return [0,0];
    }

    public static void printChessboard(int[,] chessboard)
    {
        bool squareParity = true;

        for(int i = 0; i < 8; i++)
        {
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
