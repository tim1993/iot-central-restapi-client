using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using IoTCentral_REST_ApiClient.Services;
using Microsoft.AspNetCore.Mvc;

namespace IoT_Central_REST_API_Client.Controllers.Devices
{
    [Route("api/[controller]")]
    [ApiController]
    public class DevicesController : ControllerBase
    {
        private readonly IoTCentralService _iotCentralService;
        public DevicesController(IoTCentralService iotCentralService)
        {
            _iotCentralService = iotCentralService;
        }

        // GET: api/Devices
        [HttpGet]
        public async Task<string> GetDevices()
        {
            var result = await _iotCentralService.IoTCentralInstance.GetAsync("/api/preview/devices");
            return await result.Content.ReadAsStringAsync();
        }

        // GET: api/Devices/6qqffd7112/credentials
        [HttpGet("{deviceId}/credentials")]
        public async Task<string> GetCredentials(string deviceId)
        {
            var result = await _iotCentralService.IoTCentralInstance.GetAsync($"/api/preview/devices/{deviceId}/credentials");
            return await result.Content.ReadAsStringAsync();
        }

        // GET: api/Devices/6qqffd7112/properties
        [HttpGet("{deviceId}/properties")]
        public async Task<string> GetProperties(string deviceId)
        {
            var result = await _iotCentralService.IoTCentralInstance.GetAsync($"/api/preview/devices/{deviceId}/properties");
            return await result.Content.ReadAsStringAsync();
        }

        // GET: api/Devices/6qqffd7112/cloudProperties
        [HttpGet("{deviceId}/cloudProperties")]
        public async Task<string> GetCloudProperties(string deviceId)
        {
            var result = await _iotCentralService.IoTCentralInstance.GetAsync($"/api/preview/devices/{deviceId}/cloudProperties");
            return await result.Content.ReadAsStringAsync();
        }

        // GET: api/Devices/6qqffd7112
        [HttpGet("{deviceId}")]
        public async Task<string> GetDevice(string deviceId)
        {
            var result = await _iotCentralService.IoTCentralInstance.GetAsync($"/api/preview/devices/{deviceId}");
            return await result.Content.ReadAsStringAsync();
        }

        // PUT: api/Devices/6qqffd7112
        [HttpPut("{deviceId}")]
        public async Task PutDevice(string deviceId, [FromBody] string value)
        {
            await _iotCentralService.IoTCentralInstance.PutAsync($"/api/preview/devices/{deviceId}", 
                new StringContent(value, Encoding.UTF8, "application/json"));
        }

        // PUT: api/Devices/6qqffd7112/cloudProperties
        [HttpPut("{deviceId}/cloudProperties")]
        public async Task PutCloudProperties(string deviceId, [FromBody] string value)
        {
            await _iotCentralService.IoTCentralInstance.PutAsync($"/api/preview/devices/{deviceId}/cloudProperties",
                new StringContent(value, Encoding.UTF8, "application/json"));
        }

        // PUT: api/Devices/6qqffd7112/cloudProperties
        [HttpPut("{deviceId}/properties")]
        public async Task PutProperties(string deviceId, [FromBody] string value)
        {
            await _iotCentralService.IoTCentralInstance.PutAsync($"/api/preview/devices/{deviceId}/properties",
                new StringContent(value, Encoding.UTF8, "application/json"));
        }

        // DELETE: api/Devices/6qqffd7112
        [HttpDelete("{deviceId}")]
        public async Task RemoveDevice(string deviceId)
        {
            await _iotCentralService.IoTCentralInstance.DeleteAsync($"/api/preview/devices/{deviceId}");
        }
    }
}
