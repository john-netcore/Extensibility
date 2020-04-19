using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;
using PersonRepository.Interface;

namespace PersonRepository.CSV
{
    public class CSVRepository : IPersonRepository
    {
        string _path = "people.csv";

        public IEnumerable<Person> GetPeople()
        {
            IEnumerable<Person> result;
            if (File.Exists(_path))
            {
                using (var reader = new StreamReader(_path))
                {
                    using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                    {
                        //Must convert it to a list otherwise the content is not available after the using statement.
                        result = csv.GetRecords<Person>().ToList();
                    }
                }
            }
            else
            {
                throw new FileNotFoundException("The csv file could not be found", nameof(_path));
            }

            return result;
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
