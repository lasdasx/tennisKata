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

    [Fact]
    public void Player1_scores_once()
    {
        var game = new TennisGame();

        game.Player1Scores();

        var result = game.GetScore();

        Assert.Equal("Fifteen - Love", result);
    }

    [Fact]
    public void Player2_scores_once()
    {
        var game = new TennisGame();

        game.Player2Scores();

        var result = game.GetScore();

        Assert.Equal("Love - Fifteen", result);
    }

    [Fact]
    public void Player1_scores_twice_and_Player2_scores_once()
    {
        var game = new TennisGame();

        game.Player1Scores();
        game.Player1Scores();
        game.Player2Scores();

        var result = game.GetScore();

        Assert.Equal("Thirty - Fifteen", result);
    }

    [Fact]
    public void Game_is_Deuce()
    {
        var game = new TennisGame();
        game.Player1Scores();
        game.Player1Scores();
        game.Player1Scores();
        game.Player2Scores();
        game.Player2Scores();
        game.Player2Scores();
        var result = game.GetScore();
        Assert.Equal("Deuce", result);
    }

}
