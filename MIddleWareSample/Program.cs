using Microsoft.AspNetCore.Diagnostics;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.UseMiddleware<WelcomePageMiddleware>();  Works inside of the extension Method like app.UseWelcomePage();

app.UseWelcomePage();

app.Run();
