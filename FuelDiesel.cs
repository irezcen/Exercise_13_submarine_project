using System;
using System.Collections.Generic;
using System.Text;

namespace C_3_submarine
{
    class FuelDiesel:Fuel
    {
        public FuelDiesel()
        {
            Type = "diesel";
            density = 0.85;
        }
    }
}
