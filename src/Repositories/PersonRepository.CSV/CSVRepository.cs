using System;
using System.Collections.Generic;
using PersonRepository.Interface;

namespace PersonRepository.CSV
{
    public class CSVRepository : IPersonRepository
    {
        public IEnumerable<Person> GetPeople()
        {
            throw new NotImplementedException();
        }

        public void AddPerson(Person newPerson)
        {
            throw new NotImplementedException();
        }

        public void DeletePerson(int id)
        {
            throw new NotImplementedException();
        }

        public Person GetPerson(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdatePerson(int id, Person updatedPerson)
        {
            throw new NotImplementedException();
        }
    }
}
