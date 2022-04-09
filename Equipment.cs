using System;
using System.Collections.Generic;
using System.Text;

namespace C_3_submarine
{
    class Equipment:ITransportable
    {
        private double volume, weight;
        public double Volume
        {
            get { return volume; }
            set
            {
                if (value >= 0)
                {
                    volume = value;
                    weight = value * 7.0; // assume density equal to 7000 kg/m^3 (arbitrary number)
                }
            }
        }
        public double Weight
        {
            get { return weight; }
            set
            {
                if (value >= 0)
                {
                    weight = value;
                    volume = value / 7.0; // assume density equal to 7000 kg/m^3 (arbitrary number)
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

        public string GatherData()
        {
            string ans = "";
            for (int i = 0; i < 10; i++) ans += (char)(new Random()).Next(128);
            return "Important data gathered: " + ans;
        }
        public Equipment()
        {
            Volume = 1;
        }
    }
}
