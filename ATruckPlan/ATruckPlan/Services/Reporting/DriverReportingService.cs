using ATruckPlan.Models;
using ATruckPlan.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ATruckPlan.Services.Reporting
{
    internal class DriverReportingService : IDriverReportingService
    {
        private readonly IDriverRepository _driverRepository;

        public DriverReportingService(IDriverRepository driverRepository)
        {
            this._driverRepository = driverRepository;
        }

        public IEnumerable<IDriver> GetDriversByAge(int age)
        {
            var today = DateTime.UtcNow;
            var requiredBirthDate = today.AddYears(-age);
            return _driverRepository.GetAll().Where(d => d.BirthDate < requiredBirthDate);
        }
    }
}