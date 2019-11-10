using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace IoTCentral_REST_ApiClient.Services
{
    public class IoTCentralService
    {
        private string _azureHostname;
        private string _instanceHostname;
        private string _apiToken;
        private HttpClient _iotCentralInstance;
        private HttpClient _azureInstance;

        public IoTCentralService(string azureHostname, string instanceHostname, string apiToken)
        {
            _azureHostname = azureHostname;
            _instanceHostname = instanceHostname;
            _apiToken = apiToken;

            IoTCentralInstance.DefaultRequestHeaders.Add("Authorization", _apiToken);
            IoTCentralInstance.BaseAddress = new Uri(_instanceHostname);

            //AzureInstance.DefaultRequestHeaders.Add("Authorization", string.Empty);
            AzureInstance.BaseAddress = new Uri(_azureHostname);
        }

        public HttpClient IoTCentralInstance
        {
            get
            {
                if (_iotCentralInstance == null)
                    _iotCentralInstance = new HttpClient();
                return _iotCentralInstance;
            }
        }

        public HttpClient AzureInstance
        {
            get
            {
                if (_azureInstance == null)
                    _azureInstance = new HttpClient();
                return _azureInstance;
            }
        }
    }
}
