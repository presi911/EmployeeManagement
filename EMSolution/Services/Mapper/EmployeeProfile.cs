using AutoMapper;
using DataAccess.Model.Entities;
using Services.Entities.Entry;
using Services.Entities.Out;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Mapper
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Employee, EEmployee>();
            CreateMap<Employee, SEmployee>().ReverseMap();
        }
    }
}
