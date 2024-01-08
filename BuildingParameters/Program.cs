using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Building building = new Building("350 Fifth Avenue", 129, 57, 443);
                Console.WriteLine(building.Print());
                MultiBuilding multiBuilding = new MultiBuilding("405 Lexington Avenue", 62, 51, 319, 77);
                Console.WriteLine(multiBuilding.Print());
                Console.ReadKey();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}
