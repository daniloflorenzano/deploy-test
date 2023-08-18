namespace Core;

public class Movie
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Title { get; set; }
    public int Score { get; set; }
    
    public Movie(string title, int score)
    {
        Title = title;
        Score = score;
    }
}