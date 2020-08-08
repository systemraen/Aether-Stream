using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Microsoft.Xna.Framework;
using MonoGame.Extended;
using MonoGame.Extended.Collections;
using MonoGame.Extended.Entities;
using MonoGame.Extended.Entities.Systems;

namespace MainGame.Systems
{
    class WorldSystem : EntityProcessingSystem
    {
        private World _world;
        private ComponentMapper<Transform2> _transformMapper;

        public WorldSystem() 
            : base(Aspect.All(typeof(Transform2)))
        {

        }

        public override void Begin()
        {
            base.Begin();
        }

        public override void End()
        {
            base.End();
        }

        public override void Initialize(IComponentMapperService _)
        {
            _world = new WorldBuilder()
                .Build();
        }

        public override void Process(GameTime gameTime, int entityId)
        {
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        protected override void OnEntityAdded(int entityId)
        {
            base.OnEntityAdded(entityId);            
        }

        protected override void OnEntityChanged(int entityId)
        {
            base.OnEntityChanged(entityId);
        }

        protected override void OnEntityRemoved(int entityId)
        {
            base.OnEntityRemoved(entityId);
        }
    }
}
