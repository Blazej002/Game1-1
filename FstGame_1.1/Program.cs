using System.Reflection.Metadata.Ecma335;

namespace FstGame_1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bool pickUpWeapon = false;
            var player = new Player(1, 1, 10, 1);
            var doors = new
            {
                room1 = new List<Object>{ new {hor = 5, ver = 15 }},
                room2 = new List<object>{ new {hor = 5, ver = 0 }, new{hor = 5, ver = 9}},
                room3 = new List<object>{ new {hor = 5, ver = 0 }, new{hor = 5, ver = 9}},
            };

            var room1 = new Maps(20, 16, player,doors.room1);
            var room2 = new Maps(15, 10, player, doors.room2);
            var room3 = new Maps(15, 10, player, doors.room3);
            Maps currentRoom = room1 as dynamic;
            bool leftFirstRoom = false;
            while (true)
            {
                if ((player.horizontal == 5  && player.vertical == room1._Height)&& !leftFirstRoom) { currentRoom = room2; }
                else if ((player.horizontal == 5 && player.vertical == 0)  && !leftFirstRoom) { currentRoom = room1; leftFirstRoom = false; }
                currentRoom.DrawMap();
                var userInp = Console.ReadKey().Key;
                Movement(userInp, player, currentRoom);

                Thread.Sleep(24);
                Console.Clear();
            }

        }

        private static void Movement(ConsoleKey userInp, Player player, Maps room)
        {
            switch (userInp)
            {
                case ConsoleKey.UpArrow:
                    if (player.vertical == 1) { return; }
                    player.vertical--;
                    break;
                case ConsoleKey.DownArrow:
                    if (player.vertical == (room._Height - 2)) { return; }
                    player.vertical++;
                    break;
                case ConsoleKey.LeftArrow:
                    if (player.horizontal == 1 ) {return; }
                    player.horizontal--;
                    break;
                case ConsoleKey.RightArrow:
                    if (player.horizontal == (room._Width-2)) { return; }
                    player.horizontal++;
                    break;
            }
        }
    }
}
