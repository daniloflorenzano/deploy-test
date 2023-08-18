using Core;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var movies = FakeData.Movies;

app.MapGet("/movies", () => movies);

app.Run();