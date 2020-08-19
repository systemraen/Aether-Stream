using System;
using System.Collections.Generic;
using System.Text;
using MonoGame.Extended.Entities;
using MonoGame.Extended.Entities.Systems;

namespace MainGame.Components.Unit
{
    public class Location
    {
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }
    }

    public class Destructable
    {
        public int Health { get; set; }
    }

    public enum Morality
    {
        Good,
        Evil,
        Neutral
    }

    public class Ability
    {
        public string Name;
        public int Experience;
    }

    class Stats
    {
        public int
            strength,
            intelligence,
            abilities, // TODO: move to list
            wisdom,
            agility, 
            luck, 
            charisma, 
            wit, 
            daring, 
            ethics, 
            cunning;

        public int Level { get { return abilities * wisdom; } }
        public int CalcWisdom()
        {
            /*
             * go into each ability, get exp: wisdom = totalExp
             */
            throw new NotImplementedException();
        }
    }

    // when an entity contains 2+ components, it causes a reaction
}
