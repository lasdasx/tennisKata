namespace TennisKata.Tests;

public class Tests
{
    [Fact]
    public void New_game_Score()
    {
        var game = new TennisGame();

        var result = game.GetScore();

        Assert.Equal("Love - Love", result);
    }

    [Fact]
    public void Player1_scores_once() // basic score test
    {
        var game = new TennisGame();

        game.Player1Scores();

        var result = game.GetScore();

        Assert.Equal("Fifteen - Love", result);
    }

    [Fact]
    public void Player2_scores_once() //basic score test
    {
        var game = new TennisGame();

        game.Player2Scores();

        var result = game.GetScore();

        Assert.Equal("Love - Fifteen", result);
    }

    [Fact]
    public void Player1_scores_twice_and_Player2_scores_once() // basic score test
    {
        var game = new TennisGame();

        game.Player1Scores();
        game.Player1Scores();
        game.Player2Scores();

        var result = game.GetScore();

        Assert.Equal("Thirty - Fifteen", result);
    }

    [Fact]
    public void Game_is_Deuce() //deuce test at 3-3
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
    public void Player1_has_advantage() // advantage test at 4-3
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
    public void Three_Two_is_no_advantage() // no advantage test at 3-2
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
    public void Player1_wins() // win test at 4-2
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
    public void Six_Six_is_Deuce() // deuce test at 6-6
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
    public void Six_Seven_is_Advantage2() // advantage test at 6-7
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
    public void Six_Eight_is_Wins2() // win test at 6-8
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
    public void Four_Zero_is_Wins1() // a player can win with 4 points and dif>2
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
    public void Exception_when_scoring_after_game_is_finished() //exception when game has ended

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
