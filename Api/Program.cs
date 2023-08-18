using Core;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var port = Environment.GetEnvironmentVariable("PORT") ?? "8080";
app.Urls.Add($"http://*:{port}/");

var movies = FakeData.Movies;

app.MapGet("/movies", () => movies);

app.Run();