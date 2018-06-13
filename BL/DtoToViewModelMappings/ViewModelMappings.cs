using AutoMapper;
using BL.Models.ViewModels;
using DAL.Models.Dto;

namespace BL.DtoToViewModelMappings
{
    public class ViewModelMappings : Profile
    {
        public ViewModelMappings()
        {
            CreateMap<EmployeeDto, EmployeeViewModel>()
                .ForMember(vm => vm.FullName, map => map.MapFrom(dto => dto.FirstName + " " + dto.LastName));
        }
    }
}
