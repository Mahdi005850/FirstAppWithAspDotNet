using MinimalAPI.CRUD;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/people", () =>
{
    return PersonRepository.Instance().Get();
});
var GetById = (int id) =>
{
    return PersonRepository.Instance().Get(id);
};
app.MapGet("/people/{id}", GetById);
app.MapPost("/people", PersonApplicationService.Add);
var handler = new PersonApplicationService();
app.MapDelete("/people{id}", handler.Remove);
app.Run();