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

        // code from Main()
        //Flat flat1 = new Flat();
        //Flat flat2 = new Flat();

        //Flat[] flats = new Flat[] { flat1, flat2 };

        //Entrance entrance = new Entrance(flats);

        //    foreach (var flat in entrance)
        //    {
        //        Console.WriteLine(((Flat) flat).Number); 
        //    }
}
}
