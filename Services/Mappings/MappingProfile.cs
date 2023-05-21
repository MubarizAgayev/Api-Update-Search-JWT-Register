using AutoMapper;
using Domain.Models;
using Services.DTOs.Account;
using Services.DTOs.City;
using Services.DTOs.Country;
using Services.DTOs.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<Employee, EmployeeDto>().ReverseMap();
            CreateMap<EmployeeCreateDto, Employee>();
            CreateMap<EmployeeEditDto, Employee>();

            CreateMap<RegisterDto, AppUser>();

            CreateMap<City, CityDto>().ReverseMap();
            CreateMap<CityCreateDto, City>();
            CreateMap<CityEditDto, City>();

            CreateMap<Country, CountryDto>().ReverseMap();
            CreateMap<CountryCreateDto, Country>();
            CreateMap<CountryEditDto, Country>();
        }
    }
}
