using System.Collections;

namespace MyConsoleApp
{
    public class Entrance : IEnumerable
    {
        private readonly Flat[] flats;

        public Entrance(Flat[] flats)
        {
            this.flats = flats;
        }

        public IEnumerator GetEnumerator()
        {
            return new EntranceEnumerator(flats);
        }
    }
}
