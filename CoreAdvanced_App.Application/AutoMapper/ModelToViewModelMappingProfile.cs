using AutoMapper;
using CoreAdvanced_App.Application.ViewModels.Blog;
using CoreAdvanced_App.Application.ViewModels.Common;
using CoreAdvanced_App.Application.ViewModels.Order;
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

            CreateMap<Bill, BillViewModel>();

            CreateMap<BillDetail, BillDetailViewModel>();

            CreateMap<Color, ColorViewModel>();

            CreateMap<Size, SizeViewModel>();

            CreateMap<ProductQuantity, ProductQuantityViewModel>().MaxDepth(2);

            CreateMap<ProductImage, ProductImageViewModel>().MaxDepth(2);

            CreateMap<WholePrice, WholePriceViewModel>().MaxDepth(2);

            CreateMap<Blog, BlogViewModel>().MaxDepth(2);

            CreateMap<BlogTag, BlogTagViewModel>().MaxDepth(2);

            CreateMap<Slide, SlideViewModel>().MaxDepth(2);

            CreateMap<SystemConfig, SystemConfigViewModel>().MaxDepth(2);

            CreateMap<Footer, FooterViewModel>().MaxDepth(2);

            CreateMap<Page, PageViewModel>();
        }
    }
}