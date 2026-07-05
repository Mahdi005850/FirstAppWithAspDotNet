using System.Security.Cryptography.X509Certificates;

namespace MinimalAPI.CRUD;
public class PersonApplicationService
{
    public static void Add(Person person)
    {
        PersonRepository.Instance().Add(person);
    }
    public void Remove(int id)
    {
        PersonRepository.Instance().Remove(id);
    }
}