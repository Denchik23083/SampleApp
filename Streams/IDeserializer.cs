using System.Collections.Generic;

namespace Streams
{
    public interface IDeserializer
    {
        IEnumerable<Person> DeserializeCsv();
    }
}
