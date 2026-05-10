namespace TennisKata.Tests;

public class Tests
{
    [Fact]
    public void New_game_Score()
    {
        var game = new TennisGame();

        var result = game.GetScore();

        Assert.Equal("Love All", result);
    }
}
