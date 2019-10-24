using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace Programmering2
{
    class Enemy:BasKlass
    {
        float speed = 1;
        int col = 0;
        int row = 0;

        public Enemy(Vector2 position)
        {
            this.position = position;
            texture = Assets.Pixel;
        }

        public override void Update()
        {
            position.Y += speed;
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
        }
    }
}
