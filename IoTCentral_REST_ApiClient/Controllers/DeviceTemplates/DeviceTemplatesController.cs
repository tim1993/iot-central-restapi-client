using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using IoTCentral_REST_ApiClient.Services;
using Microsoft.AspNetCore.Mvc;

namespace IoTCentral_REST_ApiClient.Controllers.DeviceTemplates
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeviceTemplatesController : ControllerBase
    {
        private readonly IoTCentralService _iotCentralService;
        public DeviceTemplatesController(IoTCentralService iotCentralService)
        {
            _iotCentralService = iotCentralService;
        }

        // GET: api/DeviceTemplates
        [HttpGet]
        public async Task<string> GetTemplates()
        {
            var result = await _iotCentralService.IoTCentralInstance.GetAsync("/api/preview/deviceTemplates");
            return await result.Content.ReadAsStringAsync();
        }

        // GET: api/DeviceTemplates/6qqffd7112
        [HttpGet("{deviceTemplateId}")]
        public async Task<string> GetDeviceTemplate(string deviceTemplateId)
        {
            var result = await _iotCentralService.IoTCentralInstance.GetAsync($"/api/preview/deviceTemplates/{deviceTemplateId}");
            return await result.Content.ReadAsStringAsync();
        }

        // GET: api/DeviceTemplates/6qqffd7112
        [HttpGet("{deviceTemplateId}/merged")]
        public async Task<string> GetMergedDeviceTemplate(string deviceTemplateId)
        {
            var result = await _iotCentralService.IoTCentralInstance.GetAsync($"/api/preview/deviceTemplates/{deviceTemplateId}/merged");
            return await result.Content.ReadAsStringAsync();
        }

        // GET: api/DeviceTemplates/6qqffd7112
        [HttpGet("{deviceTemplateId}/devices")]
        public async Task<string> GetDeviceTemplateDevices(string deviceTemplateId)
        {
            var result = await _iotCentralService.IoTCentralInstance.GetAsync($"/api/preview/deviceTemplates/{deviceTemplateId}/devices");
            return await result.Content.ReadAsStringAsync();
        }

        // DELETE: api/DeviceTemplates/6qqffd7112
        [HttpDelete("{deviceTemplateId}")]
        public async Task DeleteDeviceTemplate(string deviceTemplateId)
        {
            await _iotCentralService.IoTCentralInstance.DeleteAsync($"/api/preview/deviceTemplates/{deviceTemplateId}");
        }

        // GET: api/DeviceTemplates/6qqffd7112
        [HttpPut("{deviceTemplateId}")]
        public async Task SetDeviceTemplate(string deviceTemplateId, [FromBody] string value)
        {
            await _iotCentralService.IoTCentralInstance.PutAsync($"/api/preview/deviceTemplates/{deviceTemplateId}",
                new StringContent(value, Encoding.UTF8, "application/json"));
        }
    }
}