namespace ATruckPlan.Services
{
    public interface ILocationMetaDataService
    {
        string GetCountry(double longitude, double latitude);
    }
}