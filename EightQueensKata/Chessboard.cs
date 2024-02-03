using System.Linq;

namespace EightQueensKata;

public class Chessboard
{
    private readonly int[,] _board;

    public Chessboard()
    {
        _board = new int[8,8];
    }

    public void PlaceQueenAt(int xCoordinate, int yCoordinate) 
        => _board[xCoordinate, yCoordinate] = 1;

    public bool IsQueenAt(int xCoordinate, int yCoordinate) 
        => _board[xCoordinate, yCoordinate] == 1;

    public void Initialize()
    {
        PlaceQueenAt(0,0);
        PlaceQueenAt(1,0);
        PlaceQueenAt(2,0);
        PlaceQueenAt(3,0);
        PlaceQueenAt(4,0);
        PlaceQueenAt(5,0);
        PlaceQueenAt(6,0);
        PlaceQueenAt(7,0);
    }

    public int QueensCount()
    {
        var queenCounter = 0;
        for (var i = 0; i < _board.GetLength(0); i++)
        {
            for (var j = 0; j < _board.GetLength(1); j++)
            {
                if(!IsQueenAt(i, j)) continue;
                queenCounter++;
            }   
        }

        return queenCounter;
    }

    public bool HaveQueensAnyOtherQueenInRange()
    {
        for (var i = 0; i < _board.GetLength(0); i++)
        {
            for (var j = 0; j < _board.GetLength(1); j++)
            {
                if(!IsQueenAt(i, j)) continue;
                if (IsAnotherQueenInRange(i, j))
                {
                    return true;
                }
            }   
        }

        return false;
    }

    private bool IsAnotherQueenInRange(int xCoordinate, int yCoordinate)
    {
        for (var x = 0; x < _board.GetLength(0); x++)
        {
            if(x == xCoordinate) continue;
            if (IsQueenAt(x, yCoordinate))
                return true;
        }
        for (var y = 0; y < _board.GetLength(0); y++)
        {
            if(y == yCoordinate) continue;
            if (IsQueenAt(xCoordinate, y))
                return true;
        }
        return false;
    }
}