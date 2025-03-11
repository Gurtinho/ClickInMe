using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using MonoLink;

namespace ClickInMe
{
    class Enemy
    {
        // Definir duas animações
        // Animação de corrida e morte

        protected FrameAnimation runAnimation;
        protected FrameAnimation deathAnimation;
        protected Texture2D texture;
        float xVelocity = 2;
        int layer = 3;

        public FrameAnimation CurrentAnimation { get; protected set; }

        public Enemy(Texture2D texture)
        {
            this.texture = texture;
        }

        public void Set(float xVelocity, int layer)
        {
            this.layer = layer;
            this.xVelocity = xVelocity;
        }

        // Método de atualização do sprite
        public virtual void Update(GameTime gameTime)
        {
            if (layer == 0)
            {
                CurrentAnimation.Scale = new Vector2(2);
            }
            else if (layer == 1)
            {
                CurrentAnimation.Scale = new Vector2(1.5f);
            }
            else
            {
                CurrentAnimation.Scale = new Vector2(1f);
            }

                // Atualização da posição
                CurrentAnimation.Position += new Vector2(xVelocity, 0);

            // Inversão do inimigo quando correr na direção contrária
            if (xVelocity < 0)
            {
                CurrentAnimation.Effects = SpriteEffects.FlipHorizontally;
            }

            // Atualização da animação atual
            CurrentAnimation.Update(gameTime);
        }

        // Método somente para o desenho
        public virtual void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            CurrentAnimation.Draw(gameTime, spriteBatch);
        }
    }
}
