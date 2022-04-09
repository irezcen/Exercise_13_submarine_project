using System;
using System.Collections.Generic;
using System.Text;

namespace C_3_submarine
{
    class LifeSupportSystem
    {
        private List<OxygenBottle> oxygenBottles;
        private FoodContainer foodContainer;
        private Waste waste;
        private List<Human> crew;
        public bool CheckSuppliesBeforeTravel(double travelTime) //time given in hours
        {
            double neededOxygen = travelTime*crew.Count*5.4; //given by m^3
            double neededFood = travelTime*crew.Count* 1; //given by t
            double oxygenVolume = 0;
            foreach(OxygenBottle el in oxygenBottles)
            {
                oxygenVolume += el.GetVolume();
            }
            if (oxygenVolume < neededOxygen)
            {
                return false;
            }
            if (foodContainer.GetWeight() < neededFood)
            {
                return false;
            }
            return true;
        }
        public void Run(double travelTime)
        {
            waste.SetVolume(waste.GetVolume() + travelTime * crew.Count * 0.0005);
            foodContainer.SetWeight(foodContainer.GetWeight() - travelTime * crew.Count * 1);
            double neededOxygen = travelTime * crew.Count * 5.4;
            foreach(OxygenBottle el in oxygenBottles)
            {
                if(neededOxygen > el.GetVolume())
                {
                    neededOxygen -= el.GetVolume(); //if needed oxygen is greater then volume of 1 bottle
                    el.SetVolume(0);
                }
                else
                {
                    el.SetVolume(el.GetVolume() - neededOxygen); //if needed volume is lesser than volume of 1 bottle
                    neededOxygen = 0;
                }
            }

        }
        public LifeSupportSystem(List<OxygenBottle> _bottles, FoodContainer _container, Waste _waste, List<Human> _crew)
        {
            oxygenBottles = _bottles;
            foodContainer = _container;
            waste = _waste;
            crew = _crew;
        }
    }
}
