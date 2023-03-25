using Chat.Api.Filters;
using Chat.Api.Middleware;
using Chat.Application.Services;
using Chat.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddApplication()
    .AddInfrastructure(builder.Configuration);

builder.Services.AddControllers(
    options => options.Filters.Add<ErrorHandlingFilterAttribute>());

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{

    app.UseMiddleware<ErrorHandlingMiddleware>();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();

app.Run();
