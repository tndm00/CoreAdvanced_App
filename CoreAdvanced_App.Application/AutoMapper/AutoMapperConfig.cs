using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreAdvanced_App.Application.AutoMapper
{
    public static class AutoMapperConfig
    {
        public static MapperConfiguration RegisterMapping()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new ModelToViewModelMappingProfile());
                cfg.AddProfile(new ViewModelToModelMappingProfile());
            });
        }
    }
}
