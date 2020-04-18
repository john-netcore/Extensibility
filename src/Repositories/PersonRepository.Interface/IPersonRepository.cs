using System.Collections.Generic;

namespace PersonRepository.Interface
{
    public interface IPersonRepository
    {
        IEnumerable<Person> GetPeople();
        Person GetPerson(int id);
        void AddPerson(Person newPerson);
        void UpdatePerson(Person updatedPerson);
        void DeletePerson(int id);
    }
}