using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using SINAN.Application.AutoMapper;

namespace SINAN.Application.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<EntitiesToViewModel>();
                x.AddProfile<ViewModelToEntities>();
            });
        }
    }
}