using System;
using System.Collections.Generic;
using System.Text;

namespace C_3_submarine
{
    class OxygenBottle:IVisitPort
    {
        private double volume, weight, maxCapacity;
        public double MaxCapacity
        {
            get
            {
                return maxCapacity;
            }
            set
            {
                if(value >= 0)
                {
                    maxCapacity = value;
                }
            }
        }
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
                    volume = value;
                    weight = value * 0.00143; //density of oxygen is about 1.43g/dm^3
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
                    weight = value+0.009; //masss of empty bottle is about 9kg
                    volume = value / 0.00143; //density of oxygen is about 1.43g/dm^3
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
        public double GetCapacity()
        {
            return MaxCapacity - GetVolume();
        }
        public double VisitPort()
        {
            double cost = GetCapacity() * 50;
            SetVolume(MaxCapacity);
            return cost;
        }
        public OxygenBottle(double _capacity)
        {
            MaxCapacity = _capacity;
            SetVolume(_capacity);
        }
    }
}
