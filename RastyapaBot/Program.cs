using Microsoft.AspNetCore.Mvc;
using RastyapaBot.Interfaces;
using RastyapaBot.Models;
using RastyapaBot.Services;

DotNetEnv.Env.Load();

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<CommandService>();
builder.Services.AddSingleton<ICommandExecutor, ConfirmationCommandExecutor>();

var app = builder.Build();

app.MapPost("/", ([FromBody] Notification notification, CommandService commandService) => 
{ 
    if (notification is null)
    {
        return Results.BadRequest();
    }

    return Results.Ok(commandService.Execute(notification));
});

app.Run();