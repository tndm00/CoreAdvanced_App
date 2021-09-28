using AutoMapper;
using CoreAdvanced_App.Application.ViewModels.Order;
using CoreAdvanced_App.Application.ViewModels.Product;
using CoreAdvanced_App.Application.ViewModels.System;
using CoreAdvanced_App.Application.ViewModels.User;
using CoreAdvanced_App.Data.Entities;
using System;

namespace CoreAdvanced_App.Application.AutoMapper
{
    public class ViewModelToModelMappingProfile : Profile
    {
        public ViewModelToModelMappingProfile()
        {
            CreateMap<ProductViewModel, Product>()
               .ConstructUsing(c => new Product(c.Name, c.CategoryId, c.Image, c.Price, c.OriginalPrice,
               c.PromotionPrice, c.Description, c.Content, c.HomeFlag, c.HotFlag, c.Tags, c.Unit, c.Status,
               c.SeoPageTitle, c.SeoAlias, c.SeoKeywords, c.SeoDescription));

            CreateMap<ProductCategoryViewModel, ProductCategory>()
                            .ConstructUsing(c => new ProductCategory(c.Name, c.Description, c.ParentId, c.HomeOrder, c.Image, c.HomeFlag,
                            c.SortOrder, c.Status, c.SeoPageTitle, c.SeoAlias, c.SeoKeywords, c.SeoDescription));

            CreateMap<FunctionViewModel, Function>()
                            .ConstructUsing(c => new Function(c.Name, c.URL, c.ParentId, c.IconCss, c.SortOrder));

            CreateMap<AppUserViewModel, AppUser>()
                .ConstructUsing(c => new AppUser(c.Id.GetValueOrDefault(Guid.Empty), c.FullName, c.UserName,
                c.Email, c.PhoneNumber, c.Avatar, c.Status));

            CreateMap<PermissionViewModel, Permission>()
                .ConstructUsing(c => new Permission(c.RoleId, c.FunctionId, c.CanCreate, c.CanRead, c.CanUpdate, c.CanDelete));

            CreateMap<BillViewModel, Bill>()
                  .ConstructUsing(c => new Bill(c.Id, c.CustomerName, c.CustomerAddress,
                  c.CustomerMobile, c.CustomerMessage, c.BillStatus,
                  c.PaymentMethod, c.Status, c.CustomerId));

            CreateMap<BillDetailViewModel, BillDetail>()
              .ConstructUsing(c => new BillDetail(c.Id, c.BillId, c.ProductId,
              c.Quantity, c.Price, c.ColorId, c.SizeId));
        }
    }
}