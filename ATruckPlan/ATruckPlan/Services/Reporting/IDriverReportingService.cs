using ATruckPlan.Models;
using System.Collections.Generic;

namespace ATruckPlan.Services.Reporting
{
    internal interface IDriverReportingService
    {
        IList<IDriver> GetDriversByAge(int age);
    }
}