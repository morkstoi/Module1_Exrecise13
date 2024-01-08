using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingParameters
{
    sealed class MultiBuilding : Building
    {
        int buildingFloors;
        public int BuildingFloors
        {
            get
            {
                return buildingFloors;
            }
            set
            {
                if (value > 0)
                    buildingFloors = value;
                else
                    throw new ArgumentOutOfRangeException(nameof(buildingFloors), "Значение должно быть больше нуля.");
            }
        }
        public MultiBuilding(string buildingAdress, int buildingLength, int buildingWidth, int buildingHeight, int buildingFloors)
            : base(buildingAdress, buildingLength, buildingWidth, buildingHeight)
        {
            BuildingFloors = buildingFloors;
        }
        public string Print()
        {
            string result = base.Print();
            result += $" {BuildingFloors}";
            return result;
        }


    }
}
