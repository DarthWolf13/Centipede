using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Centipede
{
    class Mushroom : SpriteGameObject
    {
        int randomX = GameEnvironment.Random.Next(0, 470);
        int randomY = GameEnvironment.Random.Next(25, 450);
        public static int mushAmount = 20;

        public Mushroom(int x, int y) : base("spr_mushroom")
        {
            this.Position = new Vector2(randomX, randomY);
        }
    }
}
