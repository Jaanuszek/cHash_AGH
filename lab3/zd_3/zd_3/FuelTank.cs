﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd_3
{
    internal class FuelTank : IVisitPort
    {

        private Fuel fuel;

        public FuelTank(double capacity, Fuel fuel)
        {
            MaxCapacity = capacity;
            this.fuel = fuel;
        }
        public double Volume { 
            get { return fuel.Volume; }
            set 
            {
                if(value > 0)
                {
                    fuel.Volume = value;
                }
                else
                {
                    fuel.Volume = 0;
                }
                fuel.Weight = value * 2;
            }
        }
        public double Weight
        {
            get
            {
                return fuel.Weight;
            }
            set
            {
                if(value > 0)
                {
                    fuel.Weight = value;
                }
                else
                {
                    fuel.Weight = 0;
                }

                fuel.Volume = value / 2;
            }
        }
        public double MaxCapacity { get; }

        public double VisitPort()
        {
            fuel.Volume = MaxCapacity;
            if(fuel.Material == "Diesel")
            {
                return fuel.Volume * 6.21;
            }
            else
            {
                return fuel.Volume * 3.68; //podobno tyle kosztuje paliwo lotnicze bez akcyzy
            }
        }
        
        public string CheckFuelMaterial()
        {
            if(fuel.Material== "Nuclear")
            {
                return "Nuclear";
            }
            else
            {
                return "Diesel";
            }
        }

    }
}
