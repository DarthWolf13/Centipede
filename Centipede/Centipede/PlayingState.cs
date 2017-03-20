using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Centipede
{
    class PlayingState : GameObjectList
    {
        Player player;

        public PlayingState()
        {
            player = new Player();

            this.Add(new SpriteGameObject("spr_background"));
            this.Add(player);
        }
    }
}
