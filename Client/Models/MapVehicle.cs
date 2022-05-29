using System;
using Newtonsoft.Json;

namespace VehicleMapper.Client.Models
{
    public class MapVehicle
    {
        [JsonConstructor]
        public MapVehicle(string name, string model)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Model = model ?? throw new ArgumentNullException(nameof(model));
        }

        [JsonProperty("name")] public string Name { get; set; }
        [JsonProperty("model")] public string Model { get; set; }
    }
}