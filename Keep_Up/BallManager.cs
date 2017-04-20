using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;

namespace Asteroid_Belt_Assault
{
    class BallManager
    {
        public Sprite playerSprite;
        private List<Rectangle> ballRects = new List<Rectangle>();
        public BallManager(
            Texture2D texture,
            Rectangle initialFrame,
            int frameCount,
            Rectangle screenBounds)
        {
            
            playerSprite = new Sprite(
                new Vector2(500, 500),
                texture,
                initialFrame,
                Vector2.Zero);
            ballRects.Add(new Rectangle(248, 289, 516, 475));
        }
    }
}
