using BL.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Services.Contracts
{
    public interface IEmployeeService
    {
        List<EmployeeViewModel> GetAllEmployees();
    }
}
