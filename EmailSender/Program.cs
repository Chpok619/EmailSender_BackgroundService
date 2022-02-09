using EmailSender;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<ISender, Sender>();
builder.Services.AddHostedService<ExampleEmailService>();

var app = builder.Build();

app.MapGet("/", () => "Send!");

app.Run();