using ATruckPlan.Models;
using System;
using System.Collections.Generic;

namespace ATruckPlan.Repositories
{
    internal interface IDriverRepository
    {
        IDriver Get(string employeeId);

        IEnumerable<IDriver> GetAll();

        bool Remove(Guid EmployeeId);

        bool Create(IDriver driver);

        bool Update(IDriver driver);
    }
}