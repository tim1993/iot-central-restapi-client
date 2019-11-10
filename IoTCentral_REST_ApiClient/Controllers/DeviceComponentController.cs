using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IoTCentral_REST_ApiClient.Services;
using Microsoft.AspNetCore.Mvc;

namespace IoTCentral_REST_ApiClient.Controllers
{
    public class DeviceComponentController : Controller
    {
        private readonly IoTCentralService _iotCentralService;

        public DeviceComponentController(IoTCentralService iotCentralService)
        {
            _iotCentralService = iotCentralService;
        }

        // GET: api/DeviceComponent/6qqffd7112/components/sensors/properties
        [HttpGet("{deviceId, componentName}")]
        [Route("{deviceId}/components/{componentName}/properties")]
        public async Task<string> GetComponentProperties(string deviceId, string componentName)
        {
            var result = await _iotCentralService.IoTCentralInstance.GetAsync($"/api/preview/devices/{deviceId}/components/{componentName}/properties");
            return await result.Content.ReadAsStringAsync();
        }

        // GET: api/DeviceComponent/6qqffd7112/components/sensors/telemetry/temperature
        [HttpGet("{deviceId, componentName, telemetryName}")]
        [Route("{deviceId}/components/{componentName}/telemetry/{telemetryName}")]
        public async Task<string> GetTelemetryValue(string deviceId, string componentName, string telemetryName)
        {
            var result = await _iotCentralService.IoTCentralInstance.GetAsync($"/api/preview/devices/{deviceId}/components/{componentName}/telemetry/{telemetryName}");
            return await result.Content.ReadAsStringAsync();
        }

        // PUT: api/DeviceComponent/6qqffd7112/components/sensors/properties
        [HttpPut("{deviceId, componentName}")]
        [Route("{deviceId}/components/{componentName}/properties")]
        public async Task<string> PutComponentProperties(string deviceId, string componentName)
        {
            var result = await _iotCentralService.IoTCentralInstance.GetAsync($"/api/preview/devices/{deviceId}/components/{componentName}/properties");
            return await result.Content.ReadAsStringAsync();
        }
    }
}