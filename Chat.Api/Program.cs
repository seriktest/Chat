using Chat.Api.Errors;
using Chat.Api.Filters;
using Chat.Api.Middleware;
using Chat.Application.Services;
using Chat.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddApplication()
    .AddInfrastructure(builder.Configuration);


builder.Services.AddControllers();

builder.Services.AddSingleton<ProblemDetailsFactory, ChatProblemDetailsFactory>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

app.UseExceptionHandler("/error");
app.UseSwagger();
app.UseSwaggerUI();
app.MapControllers();
app.Run();
