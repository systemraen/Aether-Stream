using Microsoft.Xna.Framework.Graphics;
using MonoGame.Extended;
using System;
using System.Collections.Generic;
using System.Text;

using MonoGame.Extended.Entities;
using MonoGame.Extended.Entities.Systems;
using Microsoft.Xna.Framework;

namespace MainGame.Systems
{
    class DrawSystem : EntityDrawSystem
    {
        private SpriteBatch _spriteBatch;
        private OrthographicCamera _camera;

        public DrawSystem(SpriteBatch spriteBatch, OrthographicCamera camera)
            : base(Aspect.All(typeof(Transform2)))
        {
            this._spriteBatch = spriteBatch;
            this._camera = camera;
        }

        public override void Draw(GameTime gameTime)
        {
            _spriteBatch.Begin();

            _spriteBatch.End();
        }

        public override void Initialize(World world)
        {
            base.Initialize(world);
        }

        public override void Initialize(IComponentMapperService mapperService)
        {
            //throw new NotImplementedException();
        }
    }
}
