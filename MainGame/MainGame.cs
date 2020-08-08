using Autofac;
using MainGame.Systems;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGame.Extended;
using MonoGame.Extended.Entities;

using MainGame.Classes;

namespace MainGame
{
    public class MainGame : Game
    {        
        private GraphicsDeviceManager _graphics;
        private OrthographicCamera _camera;
        private EntityFactory _entityFactory;
        private SpriteBatch _spriteBatch;        
        private World _world;
        private IContainer Container;

        public MainGame()
        {
            // TODO: load in user settings

            _graphics = new GraphicsDeviceManager(this)
            {
                PreferredBackBufferWidth = 1920,
                PreferredBackBufferHeight = 1080,
                IsFullScreen = true
            };

            Content.RootDirectory = "Content";
            
            // TODO: Add custom pointer
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            _camera = new OrthographicCamera(GraphicsDevice);

            var builder = new ContainerBuilder();
            builder.RegisterInstance(new SpriteBatch(GraphicsDevice));
            builder.RegisterInstance(_camera);
            Container = builder.Build();

            _world = new WorldBuilder()
                .AddSystem(new WorldSystem())
                .AddSystem(new DrawSystem(new SpriteBatch(GraphicsDevice), _camera))
                .Build();

            Components.Add(_world);

            _entityFactory = new EntityFactory(_world, Content);

            base.Initialize();
        }

        protected override void LoadContent()
        {            
            
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed
                || Keyboard.GetState().IsKeyDown(Keys.Escape))
            {
                Exit();
            }

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
        }
    }
}
