using System;

public class Score
{
    //public int score
    //{
    //    get
    //    {
    //        return score;
    //    }
    //    private set
    //    {
    //        score = value; // 0?
    //    }
    //}
    public int score { get; private set; }
    public void increaseScore()
    {
        this.score++;
    }
    public void decreaseScore()
    {
        this.score--;
    }
}

public class SomeEvilProgram
{
    public static void Main()
    {
        Score score = new Score();
        score.score = 9000;

    }
}