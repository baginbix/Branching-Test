using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;

namespace Programmering2
{
    static class Assets
    {
        public static Texture2D Pixel
        {
            get;
            private set;
        }

        public static Texture2D Player
        {
            get;
            private set;
        }

        public static void LoadAssets(ContentManager content, GraphicsDevice graphicsDevice)
        {
            CreatePixel(graphicsDevice);
        }

        static void CreatePixel(GraphicsDevice graphicsDevice)
        {
            Pixel = new Texture2D(graphicsDevice, 1, 1);
            Pixel.SetData(new Color[] { Color.White });
        }
    }
}
