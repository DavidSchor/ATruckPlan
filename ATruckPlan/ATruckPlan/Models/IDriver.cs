using System;

namespace ATruckPlan.Models
{
    internal interface IDriver
    {
        Guid EmployeeId { get; }
        DateTime BirthDate { get; set; }
        String Name { get; set; }
    }
}