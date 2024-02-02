/*
 * 1. Place 8 chess queens on a 8x8 chessboard
 * 2. None of them should be able to capture any other
 */

using System.Collections;
using FluentAssertions;

namespace EightQueensKata.Tests;

public class EightQueensTest
{
    [Theory]
    [ClassData(typeof(PlaceAQueenTestData))]
    public void Place_A_Queen_On_The_Chessboard(int xCoordinate, int yCoordinate, bool expected)
    {
        var sut = new Chessboard();
        
        sut.PlaceQueenAt(xCoordinate,yCoordinate);

        sut.IsQueenAt(xCoordinate,yCoordinate).Should().Be(expected);
    }

    [Fact]
    public void Initialized_Chessboard_Has_Eight_Queens()
    {
        var sut = new Chessboard();

        sut.Initialize();

        sut.QueensCount().Should().Be(8);
    }

    private class PlaceAQueenTestData : IEnumerable<object[]>
    {
        private readonly List<object[]> _data = new List<object[]>
        {
            new object[] { 1, 1, true },
            new object[] { 0, 0, true },
            new object[] { 2, 3, true },
            new object[] { 3, 7, true },
        };

        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}