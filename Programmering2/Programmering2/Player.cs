using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Programmering2
{
    class Player : BasKlass
    {
        float speed = 10f;

        public Player(Vector2 position)
        {
            this.position = position;
            texture = Assets.Pixel;
        }

        public override void Update()
        {
            Move();
        }

        private void Move()
        {
            if (Keyboard.GetState().IsKeyDown(Keys.D))
                position.X += speed;
            else if (Keyboard.GetState().IsKeyDown(Keys.A))
                position.X -= speed;
        }
    }
}
