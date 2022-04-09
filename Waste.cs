using System;
using System.Collections.Generic;
using System.Text;

namespace C_3_submarine
{
    class Waste : IVisitPort
    {
        private double volume, weight;
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
                    weight = value * 3; // average density of waste is 3
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
                    volume = value / 3;
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
        public double VisitPort()
        {
            double cost = GetWeight() * 1000;
            SetVolume(0);
            return cost; //return cost equal to Weight times 1000
        }
    }
}
