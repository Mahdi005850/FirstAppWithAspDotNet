var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
//For handling the developerExceptions we have to do this : 
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
app.UseStaticFiles();
app.UseRouting();
app.MapGet("/", () =>
{
    throw new Exception();
});
app.Run();