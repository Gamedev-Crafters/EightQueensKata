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

    public bool ArePlacedQueensInEachOthersRange()
    {
        throw new NotImplementedException();
    }
}