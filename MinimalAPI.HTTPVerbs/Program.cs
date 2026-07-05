using MinimalAPI.HTTPVerbs;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.MapGet("/", () => "Hello World!");
app.MapGet("/People", () =>
{
    var people = PersonRepository.Instance.Get();
});
app.MapGet("/People/{id}", (int id) =>
{
    var people = new PersonRepository.Instance.Get(id);
    return people;
});
app.MapPost("/people", () =>
{
    Person newPerson = new Person
    {
        Id = 1 , 
        FirstName = "Mahdi",
        LastName = "Shahbazi"
    };
    return newPerson;
});
app.Run();