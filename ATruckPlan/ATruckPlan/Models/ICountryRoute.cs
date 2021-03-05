using System.Collections.Generic;

namespace ATruckPlan.Models
{
    internal interface ICountryRoute // Seperate from Truckplan to support different legal requirements and compliances in seperate countries
    {
        IList<ITimedLocation> RouteMeasurements { get; set; }
        string Country { get; }
    }
}