﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(string numberOfWheels)
        {
            switch (numberOfWheels)
            {
                case "2":
                    return new Motorcycle();
                case "4":
                    return new Car();
                default:
                    return new Car();
            }
        }

    }
}
