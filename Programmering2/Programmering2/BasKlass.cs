using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Programmering2
{
    abstract class BasKlass
    {
        protected Texture2D texture;
        protected Vector2 position;

        public abstract void Update();

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, new Rectangle((int)position.X, (int)position.Y, 40, 40),Color.White);
        }
    }
}
