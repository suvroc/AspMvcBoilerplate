using Application.Business.Tasks.Dto;
using AutoMapper;
using Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Application.Business.Mappings
{
    internal static class DtoMappings
    {
        public static void Map()
        {
            Mapper.CreateMap<Task, TaskDto>()
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.Name));

            Mapper.CreateMap<Task, TaskDtoLight>();

            Mapper.CreateMap<TaskDto, Task>()
                .ForMember(x => x.Category, x => x.Ignore())
                .ForMember(x => x.Status, x => x.Ignore())
                .ForMember(x => x.Id, x => x.Ignore());

            Mapper.AssertConfigurationIsValid();
        }
    }
}
