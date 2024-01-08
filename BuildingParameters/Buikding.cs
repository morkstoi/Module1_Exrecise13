using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingParameters
{
    class Building
    {
        string buildingAdress;
        int buildingLength;
        int buildingWidth;
        int buildingHeight;

        public string BuildingAdr { get; set; }
        public int BuildingLng
        {
            get
            {
                return buildingLength;
            }
            set
            {
                if (value > 0)
                    buildingLength = value;
                else
                    throw new ArgumentOutOfRangeException(nameof(buildingLength), "Значение должно быть больше нуля.");
            }
        }

        public int BuildingWid
        {
            get
            {
                return buildingWidth;
            }
            set
            {
                if (value > 0)
                    buildingWidth = value;
                else
                    throw new ArgumentOutOfRangeException(nameof(buildingWidth), "Значение должно быть больше нуля.");
            }
        }

        public int BuildingHgt
        {
            get
            {
                return buildingHeight;
            }
            set
            {
                if (value >0)
                    buildingHeight = value;
                else
                    throw new ArgumentOutOfRangeException(nameof(buildingHeight), "Значение должно быть больше нуля.");
            }
        }

        public Building(string buildingAdress, int buildingLength, int buildingWidth, int buildingHeight)
        {
            BuildingAdr = buildingAdress;
            BuildingLng = buildingLength;
            BuildingWid = buildingWidth;
            BuildingHgt = buildingHeight;
        }

        public string Print()
        {
            return $"{BuildingAdr} {BuildingLng} {BuildingWid} {BuildingHgt}";
        }

        

    }
}
