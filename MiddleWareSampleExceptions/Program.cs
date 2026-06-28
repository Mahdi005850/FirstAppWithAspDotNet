var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
//if (app.Environment.IsDevelopment())
//{
//    app.UseDeveloperExceptionPage();
//}
//else
//{
app.UseExceptionHandler("/error");
//app.MapGet("/error", () => "There is some error in application . Please try again!!");
app.MapGet("/error", () =>
{
    throw new NullReferenceException();
});
//}
app.MapGet("/", () =>
{
    throw new Exception();
});
app.Run();