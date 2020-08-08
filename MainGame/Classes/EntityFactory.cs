using Microsoft.Xna.Framework.Content;
using MonoGame.Extended.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MainGame.Classes
{
    class EntityFactory
    {
        private World world;
        private ContentManager content;

        public EntityFactory(World world, ContentManager content)
        {
            this.world = world;
            this.content = content;
        }
    }
}
