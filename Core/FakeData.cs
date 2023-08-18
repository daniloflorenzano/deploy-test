namespace Core;

public static class FakeData
{
    public static readonly List<Movie> Movies = new List<Movie>
    {
        new("The Shawshank Redemption", 9),
        new("The Godfather", 9),
        new("The Dark Knight", 8),
        new("The Godfather: Part II", 8),
    };
}