using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using IoTCentral_REST_ApiClient.Services;
using Microsoft.AspNetCore.Mvc;

namespace IoTCentral_REST_ApiClient.Controllers.Devices
{
    public class DeviceCommandController : Controller
    {
        private readonly IoTCentralService _iotCentralService;
        
        public DeviceCommandController(IoTCentralService iotCentralService)
        {
            _iotCentralService = iotCentralService;
        }

        // GET: api/Devices/6qqffd7112/components/Thermostat_1o/commands/CoolDown
        [HttpGet("{deviceId, componentName, commandName}")]
        public async Task<string> GetCommandHistory(string deviceId, string componentName, string commandName)
        {
            var result = await _iotCentralService.IoTCentralInstance.GetAsync($"/api/preview/devices/{deviceId}/components/{componentName}/commands/{commandName}");
            return await result.Content.ReadAsStringAsync();
        }

        // POST: api/Devices/6qqffd7112/components/Thermostat_1o/commands/CoolDown
        [HttpPost("{deviceId}/components/{componentName}/commands/{commandName}")]
        public async Task ExecuteCommand(string deviceId, string componentName, string commandName, [FromBody] string value)
        {
            await _iotCentralService.IoTCentralInstance.PostAsync($"/api/preview/devices/{deviceId}/components/{componentName}/commands/{commandName}",
                new StringContent(value, Encoding.UTF8, "application/json"));
        }
    }
}