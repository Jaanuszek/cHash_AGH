﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace zd_3
{
    abstract class  Human : ITransportable
    {
        protected double volume, weight;

        public virtual double Volume
        {
            get { return volume; }

            set
            {
                if(value > 0)
                {
                    volume = value;
                }
                else
                {
                    volume = 0;
                }
                weight = value * 3.0; //gestosc czlowieka to 1000kg/m^3 tak google podpowiada 
            }

        }
        public virtual double Weight
        {
            get { return weight; }

            set
            {
                if(value > 0)
                {
                    weight = value;
                }
                else
                {
                    weight = 0;
                }
                volume = value / 3.0;
            }
        }
        abstract public void Work(double time);

    }
}
