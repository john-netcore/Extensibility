using System;
using System.Collections.Generic;
using System.Linq;
using PersonRepository.Interface;
using Xunit;
using Xunit.Abstractions;

namespace PersonRepository.Service.Tests
{
    public class PersonRepositoryServiceShould
    {
        private readonly ITestOutputHelper _output;

        public PersonRepositoryServiceShould(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void RetrievePeople()
        {
            IPersonRepository sut = new ServiceRepository();

            List<Person> persons = sut.GetPeople().ToList();
            foreach (var person in persons)
            {
                _output.WriteLine(person.Id + " " + person.FirstName);
            }
            Assert.Equal(10, persons.Count());
        }
    }
}
