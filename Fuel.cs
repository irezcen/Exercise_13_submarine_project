using System;
using System.Collections.Generic;
using System.Text;

namespace C_3_submarine
{
    abstract class Fuel: ITransportable
    {
        protected double volume, weight;
        public string Type
        {
            get;
            set;
        }
        protected double density;
        public double Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if(value >= 0)
                {
                    volume = value;
                    weight = value * density;
                }
            }
        }
        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if(value >= 0)
                {
                    weight = value;
                    volume = value / density;
                }
            }
        }
        public double GetVolume() 
        {
            return Volume;
        }
        public double GetWeight()
        {
            return Weight;
        }
        public void SetVolume(double newVolume)
        {
            Volume = newVolume;            
        }
        public void SetWeight(double newWeight)
        {
            Weight = newWeight;           
        }

        public new string GetType()
        {
            return Type;
        }
    }
}
