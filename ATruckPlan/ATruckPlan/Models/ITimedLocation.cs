using System;

namespace ATruckPlan.Models
{
    internal interface ITimedLocation
    {
        DateTime ObservationTime { get; }
        double Longitude { get; }
        double Latitude { get; }
    }
}