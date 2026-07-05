namespace MinimalAPI.HTTPVerbs;
public class PersonRepository
{
    private readonly List<Person> _people = [];
    public static PersonRepository Instance => new();
    public PersonRepository()
    {
        _people.Add(new Person
        {
            Id = 1,
            FirstName = "Mahdi",
            LastName = "Shahbazi"
        });
        _people.Add(new Person
        {
            Id = 2,
            FirstName = "Arman",
            LastName = "Fatemi"
        });

        _people.Add(new Person
        {
            Id = 3,
            FirstName = "Shayan",
            LastName = "Kamyabi"
        });
        _people.Add(new Person
        {
            Id = 4,
            FirstName = "Mobin",
            LastName = "Ghobadi"
        });
    }
    public Person Get(int id)
    {
        return _people.FirstOrDefault(c => c.Id == id);
    }
    public List<Person> Get()
    {
        return _people;
    }
}