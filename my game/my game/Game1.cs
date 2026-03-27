   using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace my_game
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Texture2D _squreTexture;
        private Vector2 _playerPosition;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            _squreTexture = new Texture2D(GraphicsDevice, 1, 1);
            _squreTexture.SetData(new[] { Color.White });               

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            if (Keyboard.GetState().IsKeyDown(Keys.A))
            {
                _playerPosition.X--;
            }

            if (Keyboard.GetState().IsKeyDown(Keys.A))
            {
                _playerPosition.X++;
            }

            _playerPosition.Y++;

            _playerPosition.Y--;


            if(_playerPosition.Y <200  0)



            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();

            _spriteBatch.Draw(_squreTexture,new Rectangle(_playerPositionX,_playerPositionX,_playerPositionY,_playerPositionY),Color.Beige);

            _squreTexture.End();


            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
