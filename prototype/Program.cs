using System.Runtime.CompilerServices;
using System.Transactions;

public class Program
{
    public static void Main(string[] args)
    {
        int[,] chessboard = {{0,0,0,0,0,0,0,0},{0,0,0,0,0,0,0,0},{0,0,0,0,0,0,0,0},{0,0,0,0,0,0,0,0},{0,0,0,0,0,0,0,0},{0,0,0,0,0,0,0,0},{0,0,0,0,0,0,0,0},{0,0,0,0,0,0,0,0}};
        chessboard[3,5] = 1;

        bool quit = false;

        while (!quit)
        {
            printChessboard(chessboard);
            Console.Write("Enter Move: ");
            string move = Console.ReadLine();
            Console.WriteLine(move); 
        }
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
