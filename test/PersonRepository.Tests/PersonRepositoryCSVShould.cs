using System.Collections.Generic;
using PersonRepository.CSV;
using PersonRepository.Interface;
using Xunit;
using Xunit.Abstractions;

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
            IPersonRepository sut = new CSVRepository();

            IEnumerable<Person> persons = sut.GetPeople();
            foreach (var person in persons)
            {
                _output.WriteLine(person.Id + " " + person.FirstName);
            }
            Assert.IsType<CSVRepository>(sut);
        }
    }
}