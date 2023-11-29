using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FstGame_1._1
{
    internal class Maps
    {
        public int _Width;
        public int _Height;
        public List<Object> _Doors;
        public Player _Player;

        public Maps(int width, int height, Player player, List<Object> doors)
        {
            _Width = width;
            _Height = height;
            _Doors = doors;
            _Player = player;
        }

        public void DrawMap()
        {
            for (int ver = 0; ver < _Height; ver++)
            {
                for (int hor = 0; hor < _Width; hor++)
                {
                    bool DoorFound = false;
                    for (int i = 0; i < _Doors.Count; i++)
                    {
                        var door = _Doors[i] as dynamic;
                        if (door.ver == ver && door.hor == hor)
                        {
                            Console.Write("U");
                            DoorFound = true;
                            break;
                        }


                    }
                    if (DoorFound) continue;

                    


                    if (hor == 0 || hor == (_Width - 1))
                    {
                        Console.Write("|");
                        continue;
                    }

                    if (ver == 0 || ver == (_Height - 1))
                    {
                        Console.Write("-");
                        continue;
                    }

                    if (_Player.vertical == ver && _Player.horizontal == hor)
                    {
                        Console.Write("M");
                        continue;
                    }

                    Console.Write(" ");
                }

                Console.WriteLine();
            }
        }
    }
}