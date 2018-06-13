using AutoMapper;
using BL.Models.ViewModels;
using BL.Services.Contracts;
using DAL.Repository;
using DAL.Repository.Contracts;
using System.Collections.Generic;

namespace BL.Services.ConcreteImplementations
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IMapper mapper;
        private readonly IEmployeeRepository repository;

        public EmployeeService(IMapper mapper, IEmployeeRepository employeeRepository)
        {
            this.mapper = mapper;
            repository = employeeRepository;
        }

        public List<EmployeeViewModel> GetAllEmployees()
        {
            var employees = mapper.Map<List<EmployeeViewModel>>(repository.GetAllEmployees());
            return employees;
        }
    }
}
