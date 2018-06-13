using DAL.Models.Dto;
using System.Collections.Generic;

namespace DAL.Repository.Contracts
{
    public interface IEmployeeRepository
    {
        List<EmployeeDto> GetAllEmployees();
    }
}
