﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heroes.Game
{
    public class Mine : Building
    {
        public Mine(String Name, String Description, String FileName)
            : base(Name, Description, FileName)
        {

        }

        override public void Produce()
        {
            if (this.level > 0)
            {
                Actualamount.Plus(Actualproductivity);
                Actualamount.Limit(Capacity);
            }
            Getresources(this.Actualamount);
        }
        override public void Getresources(Resources amount)//opróżnienie budynku, przetransferowanie dobra do uzytkownika
        {
            if (this.level > 0)
            {
                Owner.Goods.Plus(amount);
                Actualamount.Minus(amount);
            }
        }
    }
}
