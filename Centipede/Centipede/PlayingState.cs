using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
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
        GameObjectList snakeSegment;

        public PlayingState()
        {
            player = new Player();
            bullet = new Bullet();
            snakeSegment = new GameObjectList();

            this.Add(new SpriteGameObject("spr_background"));           
            this.Add(bullet);
            this.Add(player);
            this.Add(snakeSegment);

            for (int i = 0; i < 10; i++)
            {
                this.snakeSegment.Add(new SnakeSegment(i * 32, 0));
            }
        }

        public override void HandleInput(InputHelper inputHelper)
        {
            base.HandleInput(inputHelper);

            if (inputHelper.IsKeyDown(Keys.Space))
            {
                bullet.FirePosition = new Vector2(player.Position.X + (player.Width - bullet.Width) / 2, player.Position.Y + 20);
                bullet.Fire();
            }
        }
    }
}
