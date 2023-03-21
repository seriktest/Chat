using Chat.Application.Services.Authentication;
using AuthenticationService = Chat.Application.Services.Authentication.AuthenticationService;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IAuthService, AuthenticationService>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();

app.Run();
