using System;
using System.Collections.Generic;
using System.Text;
using MonoGame.Extended.Entities;
using MonoGame.Extended.Entities.Systems;

namespace MainGame.Components.Unit
{
    class Location
    {
        public int x { get; set; }
        public int y { get; set; } 
        public int z { get; set; }
    }

    class Destructable
    {
        public int Health { get; set; }
    }

    class Rotation
    {
        //x y and z planes
    }

    enum Morality 
    {
        Good, 
        Evil,
        Neutral
    }

    class Stats
    {
        public int 
            strength, 
            intelligence, 
            knowledge, 
            experience, 
            level, 
            agility, 
            luck, 
            charisma, 
            wit, 
            daring, 
            ethics, 
            cunning;
    }
}
