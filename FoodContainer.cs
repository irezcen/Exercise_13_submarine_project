using System;
using System.Collections.Generic;
using System.Text;

namespace C_3_submarine
{
    class FoodContainer:IVisitPort
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
                if (value >= 0)
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
                    weight = value; //density of food is about 1kg/dm^3
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
                    volume = value; //density of food is about 1kg/dm^3
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
            double cost = GetCapacity() * 2000;
            SetVolume(MaxCapacity);
            return cost;
        }
        public FoodContainer(double _capacity)
        {
            MaxCapacity = _capacity;
            SetVolume(_capacity);
        }
    }
}
