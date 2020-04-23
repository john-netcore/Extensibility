using System.Collections.Generic;
using System.Linq;
using PersonRepository.Interface;
using PersonRepository.Factory;
using Xunit;
using Xunit.Abstractions;

namespace PersonRepository.Tests
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
            IPersonRepository sut = RepositoryFactory.GetRepository(RepositoryType.ServiceRepository);

            IEnumerable<Person> persons = sut.GetPeople();
            foreach (var person in persons)
            {
                _output.WriteLine(person.Id + " " + person.FirstName);
            }
            // Assert.IsType<ServiceRepository>(sut);
        }
    }
}
