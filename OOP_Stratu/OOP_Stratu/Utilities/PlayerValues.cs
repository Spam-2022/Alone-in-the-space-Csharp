﻿using System;

namespace OOP_Stratu.Utilities
{
    public static class PlayerValues
    {
        //SHIP VALUES
        private const int maxHealth = 100;
        private const float maxSpeed = 3;
        private const int rotationSpeed = 2;

        public static int MaxHealth { get { return maxHealth; } }
        public static float MaxSpeed { get { return maxSpeed; } }
        public static int RotationSpeed { get { return rotationSpeed; } }

        //GUN VALUES
        private const int bulletDamage = 10;
        private const float bulletMaxSpeed = 5;
        private const int bulletAcceleration = 2;

        public static int BulletDamage { get { return bulletDamage; } }
        public static float BulletMaxSpeed { get { return bulletMaxSpeed; } }
        public static int BulletAcceleration { get { return bulletAcceleration; } }

        //LEVEL
        private const int expRequired = 10;
        
        public static int ExpRequired { get { return expRequired; } }
        
        public static int NextLevelUp(int level)
        {
            return (int)(expRequired * Math.Pow(2, level)) + 1; 
        }

    }
}