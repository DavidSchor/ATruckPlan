using ATruckPlan.Services;
using OpenStreetMapIntegration.Models;
using RestSharp;
using System.Globalization;

namespace OpenStreetMapIntegration.Services
{
    public class OpenStreetMapMetadataService : ILocationMetaDataService
    {
        // https://nominatim.openstreetmap.org/reverse?lat=55.701918702183555&lon=12.596248647040307
        public string GetCountry(double longitude, double latitude)
        {
            var client = new RestClient("https://nominatim.openstreetmap.org");
            var request = new RestRequest("reverse", Method.GET);
            request.AddParameter("lat", latitude.ToString(CultureInfo.InvariantCulture));
            request.AddParameter("lon", longitude.ToString(CultureInfo.InvariantCulture));

            var response = client.Execute<Reversegeocode>(request);
            var queryResult = response.Data;

            return queryResult.Addressparts.Country;
        }
    }
}