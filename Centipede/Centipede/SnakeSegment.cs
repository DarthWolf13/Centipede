using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Centipede
{
    class SnakeSegment : SpriteGameObject
    {
        Vector2 StartPosition;
        private int speed = 200;

        public SnakeSegment() : base("spr_snakebody")
        {
            StartPosition = new Vector2(0, 0);
            this.Velocity = new Vector2(speed, 0);
        }

        public void Bounce()
        {
            if (this.position.X < 0)
            {
                this.position = new Vector2(0, position.Y + 32);
                this.Velocity *= -1;
            }

            if (this.position.X + this.sprite.Width > Centipede.Screen.X)
            {
                this.position = new Vector2(Centipede.Screen.X - this.sprite.Width, position.Y + 32);
                this.Velocity *= -1;
            }
        }
    }
}
