using System;
using System.Collections.Generic;
using System.Text;

namespace C_3_submarine
{
    class FuelTank:IVisitPort
    {

        private Fuel fuel;
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
                    if (value <= MaxCapacity)
                    {
                        fuel.SetVolume(value);
                        volume = fuel.GetVolume();
                        weight = fuel.GetWeight();
                        fuel.SetVolume(0);
                    }
                    else
                    {
                        fuel.SetVolume(MaxCapacity);
                        volume = fuel.GetVolume();
                        weight = fuel.GetWeight();
                        fuel.SetVolume(value - MaxCapacity);
                    }
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
                    fuel.SetWeight(value);
                    if (fuel.GetVolume() <= MaxCapacity)
                    {
                        volume = fuel.GetVolume();
                        weight = fuel.GetWeight() + 0.5; //base weight of empty can is 0.5t
                        fuel.SetVolume(0);
                    }
                    else
                    {
                        fuel.SetVolume(MaxCapacity);
                        volume = fuel.GetVolume();
                        weight = fuel.GetWeight() + 0.5;
                        fuel.SetWeight(value - fuel.GetWeight());
                    }
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
            double cost = GetCapacity()*5000;
            SetVolume(MaxCapacity);
            return cost;
        }
        public double GetCapacity()
        {
            return MaxCapacity - Volume;
        }
        public string GetFuelType()
        {
            return fuel.GetType();
        }
        public FuelTank(double _capacity, Fuel _fuel)
        {
            MaxCapacity = _capacity;
            fuel = _fuel;
            SetVolume(fuel.GetVolume());
        }
    }
}
