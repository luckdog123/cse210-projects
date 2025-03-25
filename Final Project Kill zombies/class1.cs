using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace ZombieSurvival
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Texture2D _playerTexture;
        private Vector2 _playerPosition;
        private float _playerSpeed = 3f;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "C:/Users/potof/Documents/CSE210/cse210-projects/Final Project Kill zombies/DALL·E 2025-03-24 17.11.43 - A simple pixel art sprite of a marine soldier facing forward. The character should be wearing a basic military uniform with a helmet, and holding a fu.webp";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            _playerPosition = new Vector2(100, 300);
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            // Ensure the "player" texture is added to the Content folder and its properties are set to "Copy if newer".
            _playerTexture = Content.Load<Texture2D>("player"); // Load player sprite
        }

        protected override void Update(GameTime gameTime)
        {
            KeyboardState state = Keyboard.GetState();
            
            if (state.IsKeyDown(Keys.Right))
                _playerPosition.X += _playerSpeed;
            if (state.IsKeyDown(Keys.Left))
                _playerPosition.X -= _playerSpeed;
            if (state.IsKeyDown(Keys.Up))
                _playerPosition.Y -= _playerSpeed;
            if (state.IsKeyDown(Keys.Down))
                _playerPosition.Y += _playerSpeed;

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            
            _spriteBatch.Begin();
            _spriteBatch.Draw(_playerTexture, _playerPosition, Color.White);
            _spriteBatch.End();
            
            base.Draw(gameTime);
        }
    }
}