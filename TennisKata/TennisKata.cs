namespace TennisKata;

public class TennisGame
{
    private int score1 = 0;
    private int score2 = 0;
    private int winner = -1;
    private int advantagePlayer = -1;

    private bool deuce = false;

    public String GetScore()
    {
        if (winner != -1)
        {
            return $"Player{winner} Wins";

        }
        if (advantagePlayer != -1)
        {
            return $"Player{advantagePlayer} Advantage";
        }
        if (deuce)
        {
            return "Deuce";
        }

        Dictionary<int, string> pairs = new Dictionary<int, string>()
        {

            { 1, "Fifteen" },
            { 2, "Thirty" },
            { 3, "Forty" }
        };


        return $"{pairs.GetValueOrDefault(score1, "Love")} - {pairs.GetValueOrDefault(score2, "Love")}";



    }

    public void Player1Scores()
    {
        if (winner != -1)
            throw new InvalidOperationException("Game is already finished");

        if (deuce)
        {
            advantagePlayer = 1;
            deuce = false;
        }
        else if (advantagePlayer == 1)
        {
            winner = 1;
        }
        else if (advantagePlayer == 2)
        {
            deuce = true;
            advantagePlayer = -1;
        }


        score1++;
        if (score1 == score2 && score1 >= 3)
        {
            deuce = true;
        }
        else if (score1 >= 4 && score1 - score2 >= 2)
        {
            winner = 1;
        }


    }

    public void Player2Scores()
    {

        if (winner != -1)
            throw new InvalidOperationException("Game is already finished");


        if (deuce)
        {
            advantagePlayer = 2;
            deuce = false;
        }
        else if (advantagePlayer == 2)
        {
            winner = 2;
        }
        else if (advantagePlayer == 1)
        {
            deuce = true;
            advantagePlayer = -1;
        }
        score2++;
        if (score1 == score2 && score1 >= 3)
        {
            deuce = true;
        }
        else if (score2 >= 4 && score2 - score1 >= 2)
        {
            winner = 2;
        }
    }
}