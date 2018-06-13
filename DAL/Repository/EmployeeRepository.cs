using AutoMapper;
using DAL.Models.Dto;
using DAL.Repository.Contracts;
using DatabasesEntities.Context;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly IMapper _mapper;
        private readonly SysKitContext sysKitContext;

        public EmployeeRepository(SysKitContext context, IMapper mapper)
        {
            sysKitContext = context;
            _mapper = mapper;
        }

        public List<EmployeeDto> GetAllEmployees()
        {
            return _mapper.Map<List<EmployeeDto>>(sysKitContext.Employees.ToList());
        }
    }
}
