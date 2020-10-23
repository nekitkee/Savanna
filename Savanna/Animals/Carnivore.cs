﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Savanna
{
    public abstract class Carnivore : Animal
    {
        public Carnivore(float health, int visionRange, int maxSpeed) :
           base(health, visionRange, maxSpeed)
        {
            
        }

        public void Eat(Herbivore victim)
        {
            if (!Position.Equals(victim.Position))
            {
                throw new InvalidOperationException("Hunter and victim should be in the same place");
            }

            victim.Die();
            //increase healt to max
        }

    }
}
