using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ClickInMe
{
    class Background
    {
        Texture2D texture;
        Game game;

        // Criado o construtor da classe
        public Background(Game game)
        {
            this.game = game;
            texture = game.Content.Load<Texture2D>("assets/stage");
        }

        // Método de desenho
        public void Draw(SpriteBatch _spriteBatch)
        {
            Console.WriteLine(game.Window.Position.X);
            _spriteBatch.Draw(texture, new Vector2(80, 15), new Rectangle(20, 23, 320, 224), Color.White, 0, Vector2.Zero, 2, SpriteEffects.None, 0);
        }
    }
}
