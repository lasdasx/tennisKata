namespace TennisKata;

public class TennisGame
{
    private int score1 = 0;
    private int score2 = 0;

    public String GetScore()
    {
        Dictionary<int, string> pairs = new Dictionary<int, string>()
        {

            { 1, "Fifteen" },
            { 2, "Thirty" },
            { 3, "Forty" }
        };
        if (score1 == score2 && score1 == 0)
        {
            return "Love All";
        }

        return $"{pairs.GetValueOrDefault(score1, "Love")} - {pairs.GetValueOrDefault(score2, "Love")}";


    }

    public void Player1Scores()
    {
        score1++;
    }

    public void Player2Scores()
    {
        score2++;
    }
}