using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Centipede
{
    class Player : SpriteGameObject
    {
        Vector2 StartPosition;

        public Player() : base("spr_player")
        {
            StartPosition = new Vector2(235, 500);

            this.Reset();
        }

        public override void Reset()
        {
            base.Reset();

            this.Position = StartPosition;
        }
    }
}
