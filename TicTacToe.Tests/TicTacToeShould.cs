using System;
using Xunit;
using TicTacToe;
namespace TicTacToe.Tests
{
    public class TicTacToeShould
    {
        [Fact]
        public void IsSymbolXStartingFirst()
        {
            TicTacToe ticTacToe = new TicTacToe();
            string result = ticTacToe.InitialPlayer();

            string expected = "X";

            Assert.Equal(expected, result);
        }
    }
}
