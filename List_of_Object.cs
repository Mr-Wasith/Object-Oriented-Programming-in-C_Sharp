using System;
namespace Array_Of_List
{
    class Player
    {
        public string Name;
        public Player(string name)
        { 
            this.Name = name; 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Player> player = new List<Player>();

            Player P1 = new Player("Messi");
            Player P2 = new Player("Suarez");
            Player P3 = new Player("Neymar");

            player.Add(P1);
            player.Add(P2);
            player.Add(P3);

            foreach (Player p in player)
            {
                Console.WriteLine(p.Name);
            }
        }
    }
}