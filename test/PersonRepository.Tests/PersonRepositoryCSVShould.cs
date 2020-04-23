using PersonRepository.Interface;
using PersonRepository.Factory;
using Xunit;
using Xunit.Abstractions;
using System.Collections.Generic;

namespace PersonRepository.Tests
{
    public class PersonRepositoryCSVShould
    {
        private readonly ITestOutputHelper _output;

        public PersonRepositoryCSVShould(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void RetrievePeople()
        {
            IPersonRepository sut = RepositoryFactory.GetRepository(RepositoryType.CSVRepository);

            IEnumerable<Person> persons = sut.GetPeople();
            foreach (var person in persons)
            {
                _output.WriteLine(person.Id + " " + person.FirstName);
            }
            // Assert.IsType<CSVRepository>(sut);
        }
    }
}