﻿using System;

namespace OOP_Stratu.Model.Entities
{
    public interface IShip : IEntity
    {
        ///<summary>
        ///</summary>
        public IBullet Shot();

        ///<summary>
        ///</summary>
        public IGun Gun { set; }

        ///<summary>
        ///</summary>
        public void Hit(int damage);

    }
}