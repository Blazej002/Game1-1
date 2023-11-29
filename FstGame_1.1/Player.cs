using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FstGame_1._1
{
    internal class Player
    {
        public int vertical;
        public int horizontal;
        public int hp;
        public int dmg;
        public bool holdingWeapon;

        public Player(int playerVert, int playerHor, int hp, int dmg)
        {
            this.horizontal = playerVert;
            this.vertical = playerHor;
            this.hp = hp;
            this.dmg = dmg;
            this.holdingWeapon = false;
        }

        public void CheckForWeapon()
        {
            if (holdingWeapon)
            {
                dmg += 2;
            }

        }

    }
}
