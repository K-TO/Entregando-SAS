using Entregando.App.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;

namespace Entregando.App.Services
{
    public class CallApiService
    {
        public JsonResponseModel GetCustomerDetailsByCustomerId(int id)
        {
            var client = new RestClient("https://localhost:44368/api/viaje?empleadoId=" + id);
            var request = new RestRequest(Method.GET);
            request.AddHeader("X-Token-Key", "dsds-sdsdsds-swrwerfd-dfdfd");
            IRestResponse response = client.Execute(request);
            var content = response.Content; // raw content as string
            dynamic json = JsonConvert.DeserializeObject(content);
            JObject responseObjJson = json;
            return responseObjJson.ToObject<JsonResponseModel>();
        }

        public JsonResponseModel GetCustomerDetailsByFilter(DateTime Fecha, int empleadoId = 0, string placa = "")
        {
            string url = string.Format("https://localhost:44368/api/viaje?fecha={0}&empleadoId={1}&placa={2}", Fecha, empleadoId, placa);
            var client = new RestClient(url);
            var request = new RestRequest(Method.GET);
            request.AddHeader("X-Token-Key", "dsds-sdsdsds-swrwerfd-dfdfd");
            IRestResponse response = client.Execute(request);
            var content = response.Content; // raw content as string
            dynamic json = JsonConvert.DeserializeObject(content);
            JObject responseObjJson = json;
            return responseObjJson.ToObject<JsonResponseModel>();
        }
    }
}
