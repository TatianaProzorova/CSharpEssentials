using System;
using System.Collections;

namespace MyConsoleApp
{
    public class Flat
    {
        public int Number { get; set; }
        public int RoomsCount { get; set; }

        public override string ToString()
        { 
            return $"Квартира с номером {Number} имеет {RoomsCount} комнат";
        }
    }

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

    public class EntranceEnumerator : IEnumerator
    {
        private readonly Flat[] flats;
        private int currentIndex = -1;

        public EntranceEnumerator(Flat[] flats)
        {
            this.flats = flats;
        }

        public object Current => flats[currentIndex];

        public bool MoveNext()
        {
            currentIndex++;
            if (currentIndex >= flats.Length)
            {
                return false;
            }

            return true;
        }

        public void Reset()
        {
            currentIndex = -1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Flat flat1 = new Flat();
            Flat flat2 = new Flat();

            Flat[] flats = new Flat[] { flat1, flat2 };

            Entrance entrance = new Entrance(flats);

            foreach (var flat in entrance)
            {
                Console.WriteLine(((Flat)flat).Number); 
            }
        }
    }
}
