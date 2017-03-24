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
        GameObjectList snakeSegments;
        GameObjectList mushrooms;

        public PlayingState()
        {
            player = new Player();
            bullet = new Bullet();
            snakeSegments = new GameObjectList();
            mushrooms = new GameObjectList();

            this.Add(new SpriteGameObject("spr_background"));           
            this.Add(bullet);
            this.Add(player);
            this.Add(snakeSegments);
            this.Add(mushrooms);

            for (int i = 0; i < SnakeSegment.snakeLenght; i++)
            {
                if (i < SnakeSegment.snakeLenght - 1)
                {
                    this.snakeSegments.Add(new SnakeSegment(i * 32, 0, "spr_snakebody"));
                }

                if (i == SnakeSegment.snakeLenght - 1)
                {
                    this.snakeSegments.Add(new SnakeSegment(i * 32, 0, "spr_snakehead"));
                }
            }

            for (int i = 0; i < Mushroom.mushAmount; i++)
            {
                this.mushrooms.Add(new Mushroom(0, 0));
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

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            foreach (SnakeSegment snakeSegment in snakeSegments.Objects)
            {
                foreach (Mushroom mushroom in mushrooms.Objects){

                    if (snakeSegment.CollidesWith(mushroom)){
                        snakeSegment.Bounce();
                    }
                }
            }

            foreach (Mushroom mushroom in mushrooms.Objects)
            {
                if (bullet.CollidesWith(mushroom))
                {
                    bullet.Reset();
                    mushrooms.Remove(mushroom);
                    break;
                }                
            }

            foreach (Mushroom mushroom in mushrooms.Objects)
            {
                foreach (SnakeSegment snakeSegment in snakeSegments.Objects)
                {
                    if (bullet.CollidesWith(snakeSegment))
                    {
                        bullet.Reset();
                        snakeSegments.Remove(snakeSegment);
                        break;
                    }
                    
                }
                
            }
        }
    }
}
