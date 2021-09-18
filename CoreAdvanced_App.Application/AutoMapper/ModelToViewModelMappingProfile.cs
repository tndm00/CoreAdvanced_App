using AutoMapper;
using CoreAdvanced_App.Application.ViewModels.Product;
using CoreAdvanced_App.Application.ViewModels.System;
using CoreAdvanced_App.Application.ViewModels.User;
using CoreAdvanced_App.Data.Entities;

namespace CoreAdvanced_App.Application.AutoMapper
{
    public class ModelToViewModelMappingProfile : Profile
    {
        public ModelToViewModelMappingProfile()
        {
            CreateMap<Product, ProductViewModel>().ConstructUsing(_ => new ProductViewModel());

            CreateMap<ProductCategory, ProductCategoryViewModel>().ConstructUsing(_ => new ProductCategoryViewModel());

            CreateMap<Function, FunctionViewModel>().ConstructUsing(_ => new FunctionViewModel());

            CreateMap<AppUser, AppUserViewModel>();

            CreateMap<AppRole, AppRoleViewModel>();
        }
    }
}