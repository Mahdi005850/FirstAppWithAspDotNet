var builder = WebApplication.CreateBuilder(args);//Setting of our object 

builder.Services.AddHttpLogging(c => c.LoggingFields = Microsoft.AspNetCore.HttpLogging.HttpLoggingFields.RequestProperties);

builder.Logging.AddFilter("Microsoft.ASP.NetCore.HttpLogging", LogLevel.Information);

var app = builder.Build();//build the object 

app.UseHttpLogging();

app.MapGet("/", () => "Hello World!");//Set the pipeline and endpoint 
app.MapGet("/Peerson", () => new Person("Mahdi", "Shahbazi"));

app.Run();//to run the app , getting ready to get the http request and give the http response!!
public record Person (string FirstName , string LastName);