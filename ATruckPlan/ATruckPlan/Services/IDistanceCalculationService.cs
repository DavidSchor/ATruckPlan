using ATruckPlan.Models;
using System.Collections.Generic;

namespace ATruckPlan.Services
{
    internal interface IDistanceCalculationService
    {
        double GetDistanceDriven(ITruckPlan truckPlan);

        double GetDistanceDriven(IList<ITimedLocation> route);

        // Naive approach could be to use something like this:  https://www.movable-type.co.uk/scripts/latlong.html between sets of coordinates and assume direct flight between coordinates
        // Better approach would load in actual road network/map and find shortest path (or least turns path) between two readings. Consider openstreetmap.
    }
}