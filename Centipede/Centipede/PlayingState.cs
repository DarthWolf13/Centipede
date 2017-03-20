using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Centipede
{
    class PlayingState : GameObjectList
    {
        Player player;
        Bullet bullet;

        public PlayingState()
        {
            player = new Player();
            bullet = new Bullet();

            this.Add(new SpriteGameObject("spr_background"));
            this.Add(player);
            this.Add(bullet);
        }
    }
}
