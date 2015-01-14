using Application.Business.Tasks.Dto;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Business.Mappings
{
    internal static class DtoMappings
    {
        public static void Map()
        {
            Mapper.CreateMap<Task, TaskDto>()
                .ForMember(x => x.CategoryName, x => x.MapFrom(y => y.Status.ToString()));

            Mapper.CreateMap<Task, TaskDtoLight>();
        }
    }
}
