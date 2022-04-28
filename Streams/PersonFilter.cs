using System.Collections.Generic;
using System.Linq;

namespace Streams
{
    public class PersonFilter
    {
        private readonly IEnumerable<Person> _people;

        public PersonFilter(IDeserializer deserializer)
        {
            _people = deserializer.DeserializeCsv();
        }

        public IEnumerable<Person> GetAdults()
        {
            return _people.Where(p => p.IsAdult);
        }
    }
}
