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

    [Fact]
    public void Player1_has_advantage()
    {
        var game = new TennisGame();
        game.Player1Scores();
        game.Player1Scores();
        game.Player1Scores();
        game.Player2Scores();
        game.Player2Scores();
        game.Player2Scores();
        game.Player1Scores();
        var result = game.GetScore();
        Assert.Equal("Player1 Advantage", result);
    }

    [Fact]
    public void Three_Two_is_no_advantage()
    {
        var game = new TennisGame();
        game.Player1Scores();
        game.Player1Scores();
        game.Player1Scores();
        game.Player2Scores();
        game.Player2Scores();
        var result = game.GetScore();
        Assert.Equal("Forty - Thirty", result);
    }

    [Fact]
    public void Player1_wins()
    {
        var game = new TennisGame();
        game.Player1Scores();
        game.Player1Scores();
        game.Player1Scores();
        game.Player2Scores();
        game.Player2Scores();
        game.Player2Scores();
        game.Player1Scores();
        game.Player1Scores();
        var result = game.GetScore();
        Assert.Equal("Player1 Wins", result);
    }

    [Fact]
    public void Six_Six_is_Deuce()
    {
        var game = new TennisGame();
        game.Player1Scores();
        game.Player1Scores();
        game.Player1Scores();
        game.Player2Scores();
        game.Player2Scores();
        game.Player2Scores();
        game.Player1Scores();
        game.Player2Scores();
        game.Player1Scores();

        game.Player2Scores();
        var result = game.GetScore();
        Assert.Equal("Deuce", result);
    }
    [Fact]
    public void Six_Seven_is_Advantage2()
    {
        var game = new TennisGame();
        game.Player1Scores();
        game.Player1Scores();
        game.Player1Scores();
        game.Player2Scores();
        game.Player2Scores();
        game.Player2Scores();
        game.Player1Scores();
        game.Player2Scores();
        game.Player1Scores();
        game.Player2Scores();
        game.Player2Scores();

        var result = game.GetScore();
        Assert.Equal("Player2 Advantage", result);
    }
    [Fact]
    public void Six_Eight_is_Wins2()
    {
        var game = new TennisGame();
        game.Player1Scores();
        game.Player1Scores();
        game.Player1Scores();
        game.Player2Scores();
        game.Player2Scores();
        game.Player2Scores();
        game.Player1Scores();
        game.Player2Scores();
        game.Player1Scores();
        game.Player2Scores();
        game.Player2Scores();
        game.Player2Scores();
        var result = game.GetScore();
        Assert.Equal("Player2 Wins", result);
    }

    [Fact]
    public void Four_Zero_is_Wins1()
    {
        var game = new TennisGame();
        game.Player1Scores();
        game.Player1Scores();
        game.Player1Scores();
        game.Player1Scores();


        var result = game.GetScore();
        Assert.Equal("Player1 Wins", result);
    }

    [Fact]
    public void Exception_when_scoring_after_game_is_finished()

    {

        var game = new TennisGame();
        game.Player1Scores();
        game.Player1Scores();
        game.Player1Scores();
        game.Player1Scores();

        Assert.Throws<InvalidOperationException>(() =>

        {
            game.Player1Scores();
        });

    }
}
