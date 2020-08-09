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
        private ComponentMapper<Transform2> _transformMapper;

        public DrawSystem(SpriteBatch spriteBatch, OrthographicCamera camera)
            : base(Aspect.All(typeof(Transform2)))
        {
            this._spriteBatch = spriteBatch;
            this._camera = camera;
        }
        public override void Initialize(IComponentMapperService mapperService)
        {
            _transformMapper = mapperService.GetMapper<Transform2>();
        }

        public override void Draw(GameTime gameTime)
        {
            _spriteBatch.Begin(samplerState: SamplerState.PointClamp, transformMatrix: _camera.GetViewMatrix());

            foreach (var entity in ActiveEntities)
            {
                var transform = _transformMapper.Get(entity);

                _spriteBatch.DrawPoint(transform.Position, Color.Red);
            }

            _spriteBatch.End();
        }
    }
}
