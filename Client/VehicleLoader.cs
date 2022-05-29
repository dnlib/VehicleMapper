using System.Collections.Generic;
using CitizenFX.Core;
using CitizenFX.Core.Native;
using Newtonsoft.Json;
using VehicleMapper.Client.Models;

namespace VehicleMapper.Client
{
    public class VehicleLoader : BaseScript
    {
        public static List<MapVehicle> GetVehicles()
        {
            var fileContents = API.LoadResourceFile(API.GetCurrentResourceName(), "vehicles.json");
            var vehicles = JsonConvert.DeserializeObject<List<MapVehicle>>(fileContents);

            return vehicles;
        }
    }
}