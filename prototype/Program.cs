int[,] chessboard = {{0,0,0,0,0,0,0,0},{0,0,0,0,0,0,0,0},{0,0,0,0,0,0,0,0},{0,0,0,0,0,0,0,0},{0,0,0,0,0,0,0,0},{0,0,0,0,0,0,0,0},{0,0,0,0,0,0,0,0},{0,0,0,0,0,0,0,0}};
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
    }
    if (squareParity)
    {
        squareParity = false;
    }
    else
    {
        squareParity = true;
    }
    Console.Write("\n");
}

Console.WriteLine("WOAW its a chessboard!!!");