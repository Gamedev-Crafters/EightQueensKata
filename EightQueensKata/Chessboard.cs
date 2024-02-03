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
        PlaceQueenAt(0,5);
        PlaceQueenAt(1,3);
        PlaceQueenAt(2,6);
        PlaceQueenAt(3,0);
        PlaceQueenAt(4,7);
        PlaceQueenAt(5,1);
        PlaceQueenAt(6,4);
        PlaceQueenAt(7,2);
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
        if (CheckForDiagonalRange(xCoordinate, yCoordinate)) return true;

        if (CheckForHorizontalAndVerticalRange(xCoordinate, yCoordinate)) return true;
        
        return false;
    }

    private bool CheckForDiagonalRange(int xCoordinate, int yCoordinate)
    {
        // Verificar la diagonal superior derecha
        for (int x = xCoordinate - 1, y = yCoordinate + 1; x >= 0 && y < _board.GetLength(1); x--, y++)
        {
            if (x == xCoordinate && y == yCoordinate) continue;
            if (IsQueenAt(x, y))
            {
                return true;
            }
        }

        // Verificar la diagonal superior izquierda
        for (int x = xCoordinate - 1, y = yCoordinate - 1; x >= 0 && y >= 0; x--, y--)
        {
            if (x == xCoordinate && y == yCoordinate) continue;
            if (IsQueenAt(x, y))
            {
                return true;
            }
        }

        return false;
    }

    private bool CheckForHorizontalAndVerticalRange(int xCoordinate, int yCoordinate)
    {
        for (var x = 0; x < _board.GetLength(0); x++)
        {
            if (x == xCoordinate) continue;
            if (IsQueenAt(x, yCoordinate))
                return true;
        }

        for (var y = 0; y < _board.GetLength(0); y++)
        {
            if (y == yCoordinate) continue;
            if (IsQueenAt(xCoordinate, y))
                return true;
        }

        return false;
    }
}