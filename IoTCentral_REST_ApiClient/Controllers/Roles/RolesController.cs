using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IoTCentral_REST_ApiClient.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IoTCentral_REST_ApiClient.Controllers.Roles
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly IoTCentralService _iotCentralService;
        public RolesController(IoTCentralService iotCentralService)
        {
            _iotCentralService = iotCentralService;
        }

        // GET: api/Roles
        [HttpGet]
        public async Task<string> GetTemplates()
        {
            var result = await _iotCentralService.IoTCentralInstance.GetAsync($"/api/preview/roles");
            return await result.Content.ReadAsStringAsync();
        }

        // GET: api/Roles/ca310b8d-2f4a-44e0-a36e-957c202cd8d4
        [HttpGet("{roleId}")]
        public async Task<string> GetTemplate(Guid roleId)
        {
            var result = await _iotCentralService.IoTCentralInstance.GetAsync($"/api/preview/roles/{roleId}");
            return await result.Content.ReadAsStringAsync();
        }
    }
}