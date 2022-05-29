using CitizenFX.Core;

namespace VehicleMapper.Client
{
    public class ClientMain : BaseScript
    {
        public ClientMain()
        {
            Debug.WriteLine("Loading vehicles to be mapped");
            var vehicles = VehicleLoader.GetVehicles();
            
            Debug.WriteLine("Starting mapping routine");
            Mapper.MapVehicles(vehicles);
        }
    }
}