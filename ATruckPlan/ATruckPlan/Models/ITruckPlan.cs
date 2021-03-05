using System.Collections.Generic;

namespace ATruckPlan.Models
{
    internal interface ITruckPlan
    {
        IDriver Driver { get; }
        IList<ICountryRoute> Routes { get; set; }
    }
}