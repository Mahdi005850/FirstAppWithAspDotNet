namespace MinimalAPI.CRUD;
public class PersonRepository
{
    private readonly List<Person> _people = [];
    private static PersonRepository _instance;
    public static PersonRepository Instance()
    {
        _instance ??= new PersonRepository();
        return _instance;
    }
    private PersonRepository()
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
    public void Add(Person person)
    {
        _people.Add(person);
    }
    public void Remove(int _id)
    {
        var person = _people.FirstOrDefault((c) => c.Id == _id);
        _people.Remove(person);
    }
}