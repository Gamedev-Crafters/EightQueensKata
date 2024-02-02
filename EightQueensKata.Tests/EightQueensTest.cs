/*
 * 1. Place 8 chess queens on a 8x8 chessboard
 * 2. None of them should be able to capture any other
 */

using FluentAssertions;

namespace EightQueensKata.Tests;

public class EightQueensTest
{
    [Fact]
    public void Place_A_Queen_On_The_Chessboard()
    {
        var sut = new Chessboard();
        
        sut.PlaceQueenAt(0,0);

        sut.IsQueenAt(0,0).Should().Be(true);
    }
}