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
}