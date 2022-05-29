using System.Collections.Generic;
using CitizenFX.Core;
using CitizenFX.Core.Native;
using VehicleMapper.Client.Models;

namespace VehicleMapper.Client
{
    public class Mapper : BaseScript
    {
        public static void MapVehicles(List<MapVehicle> vehicles)
        {
            foreach (var vehicle in vehicles)
            {
                Debug.WriteLine($"Mapping {vehicle.Model} to {vehicle.Name}");
                API.AddTextEntry(vehicle.Model, vehicle.Name);
            }
        }
    }
}