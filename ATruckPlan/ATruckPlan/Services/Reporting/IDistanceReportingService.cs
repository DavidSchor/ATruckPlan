using ATruckPlan.Models;
using System;
using System.Collections.Generic;

namespace ATruckPlan.Services.Reporting
{
    internal interface IDistanceReportingService
    {
        double TotalDistanceDriven(DateTime startDate, DateTime endDate, IList<IDriver> drivers, IList<string> countries);
    }
}