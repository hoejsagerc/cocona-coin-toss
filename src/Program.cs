using Cocona;

var builder = CoconaApp.CreateBuilder();

var app = builder.Build();

app.AddCommands<TossCommands>();

app.Run();
