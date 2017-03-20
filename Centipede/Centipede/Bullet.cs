using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Centipede
{
    class Bullet : SpriteGameObject
    {
        Vector2 StartPosition;

        public Bullet() : base("spr_bullet")
        {
            StartPosition = new Vector2(-100, -100);

            this.Reset();
        }

        public override void Reset()
        {
            base.Reset();

            this.Velocity = Vector2.Zero;
            this.Position = StartPosition;
        }
    }
}
