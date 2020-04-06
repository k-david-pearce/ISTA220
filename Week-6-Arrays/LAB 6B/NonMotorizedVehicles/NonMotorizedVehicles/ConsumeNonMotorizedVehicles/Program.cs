using Enumerations;
using NonMotorizedVehicles;
using Structures;
using System;

namespace ConsumeNonMotorizedVehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                    Bicycle bike = new Bicycle
                    {
                        TerrainType = "Beach",
                        NoOfTires = 2
                    };

                    Tricycle trike = new Tricycle
                    {
                        TerrainType = "City",
                        NoOfTires = 3
                    }

                    Bicycle bikeTwin = bike;
                    bikeTwin.Terraintype = TerrainType.AllTerrain;
                    Console.WriteLine($"bike has terrain type {bike.TerrainType}");

                    Tricycle trikeTwin = trike;
                    autoTwin.Terraintype = TerrainType.Mountain;
                    Console.WriteLine($"trike has terrain type {trike.TerrainType}");
            }
            catch (Exception e)
            { throw e; }


        }
    }
}
