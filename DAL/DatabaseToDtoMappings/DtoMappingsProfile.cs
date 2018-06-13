using AutoMapper;
using DAL.Models.Dto;
using DatabasesEntities.Models;

namespace DAL.DatabaseToDtoMappings
{
    public class DtoMappingsProfile : Profile
    {
        public DtoMappingsProfile()
        {
            CreateMap<Employee, EmployeeDto>();
        }
    }
}
