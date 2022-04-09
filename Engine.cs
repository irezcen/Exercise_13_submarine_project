using System;
using System.Collections.Generic;
using System.Text;

namespace C_3_submarine
{
    class Engine
    {
        private FuelTank tank;
        private Waste waste;
        public double GetVelocity(double submarineWeight)
        {
            if (tank.GetFuelType() == "diesel")
            {
                return 5 + 10000 / submarineWeight;
            }
            if(tank.GetFuelType()== "nuclear")
            {
                return 3 + 30000 / submarineWeight;
            }
            return 0;
        }
        public bool CheckFuelBeforeTravel(double travelTime)
        {
            if (tank.GetFuelType() == "diesel")
            {
                double neededFuel = travelTime * 0.001;
                if(neededFuel > tank.GetVolume())
                {
                    return false;
                }
                return true;
            }
            if(tank.GetFuelType() == "nuclear")
            {
                double neededFuel = travelTime * 0.0001;
                if (neededFuel > tank.GetVolume())
                {
                    return false;
                }
                return true;
            }
            return false;
        }
        public void Travel(double travelTime)
        {
            if (tank.GetFuelType() == "diesel")
            {
                tank.SetVolume(tank.GetVolume() - travelTime * 0.001);
            }
            if (tank.GetFuelType() == "nuclear")
            {
                tank.SetVolume(tank.GetVolume() - travelTime * 0.0001);
            }
            waste.SetVolume(waste.GetVolume() + travelTime * 0.001);
        }
        public Engine(FuelTank _tank, Waste _waste)
        {
            tank = _tank;
            waste = _waste;
        }
    }
}
