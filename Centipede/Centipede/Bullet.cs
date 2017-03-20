using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Centipede
{
    class Bullet : SpriteGameObject
    {
        Vector2 StartPosition;
        Vector2 FirePosition;
        private int speed = 200;

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

        public void Fire()
        {
            this.Position = FirePosition;
            this.Velocity = new Vector2(0, -speed);
        }

        public override void HandleInput(InputHelper inputHelper)
        {
            base.HandleInput(inputHelper);

            if (inputHelper.IsKeyDown(Keys.Space))
            {
                Fire();
            }
        }
    }
}
