using ATruckPlan.Services;

namespace OpenStreetMapIntegration.Services
{
    internal class OpenStreetMapMetadataService : ILocationMetaDataService
    {
        // https://nominatim.openstreetmap.org/reverse?lat=55.701918702183555&lon=12.596248647040307
        public string GetCountry(double longitude, double latitude)
        {
            throw new System.NotImplementedException();
        }
    }
}