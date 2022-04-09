using System;
using System.Collections.Generic;
using System.Text;

namespace C_3_submarine
{
    abstract class Human:ITransportable
    {
        protected double volume, weight;
        public double Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value >= 0)
                {
                    weight = value; //human density is about 1
                    volume = value;
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
                if (value >= 0)
                {
                    weight = value;
                    volume = value;
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
        public Human()
        {
            SetWeight(0.08);
        }
    }
}
