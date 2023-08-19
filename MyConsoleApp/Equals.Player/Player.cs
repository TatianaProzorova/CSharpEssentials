namespace MyConsoleApp
{
    public class Player
    {
        public string Name { get; }
        public int Number { get; }
        public Player(string name, int number)
        {
            Name = name;
            Number = number;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (GetType() != obj.GetType()) return false;

            Player other = (Player)obj;

            return Name.Equals(other.Name) && Number.Equals(other.Number);
        }

        // code in Main()
        //Player player1 = new Player("Sergio Ramos", 4);
        //Player player2 = new Player("Sergio Ramos", 4);
        //Console.WriteLine(player1.Equals(player2));
    }
}



