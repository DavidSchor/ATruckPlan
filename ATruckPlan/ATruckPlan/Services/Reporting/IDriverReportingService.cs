using ATruckPlan.Models;
using System.Collections.Generic;

namespace ATruckPlan.Services.Reporting
{
    public interface IDriverReportingService
    {
        IEnumerable<IDriver> GetDriversByAge(int age);
    }
}