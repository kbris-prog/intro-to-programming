var builder = WebApplication.CreateBuilder(args);

Console.WriteLine("Hello, World!");

Console.WriteLine("meowwwwwwww");

string message = "I love Argy";

Console.WriteLine($"The really important msg I have to say is: {message}");

var app = builder.Build();

string finalMessage = $"The Message {message}";

app.MapGet("/message", () =>
{
    return Results.Ok(finalMessage);
});

app.Run();