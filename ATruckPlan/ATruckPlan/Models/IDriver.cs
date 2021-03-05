using System;

namespace ATruckPlan.Models
{
    public interface IDriver
    {
        Guid EmployeeId { get; }
        DateTime BirthDate { get; set; }
        String Name { get; set; }
    }
}