using AutoMapper;
using CoreAdvanced_App.Application.ViewModels.Product;
using CoreAdvanced_App.Application.ViewModels.System;
using CoreAdvanced_App.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreAdvanced_App.Application.AutoMapper
{
    public class ViewModelToModelMappingProfile : Profile
    {
        public ViewModelToModelMappingProfile()
        {
            //CreateMap<ProductViewModel, Product>()
            //    .ConstructUsing(_ => new Product(_.Comment));

            CreateMap<ProductCategoryViewModel, ProductCategory>()
                            .ConstructUsing(c => new ProductCategory(c.Name, c.Description, c.ParentId, c.HomeOrder, c.Image, c.HomeFlag,
                            c.SortOrder, c.Status, c.SeoPageTitle, c.SeoAlias, c.SeoKeywords, c.SeoDescription));

            CreateMap<FunctionViewModel, Function>()
                            .ConstructUsing(c => new Function(c.Name, c.URL, c.ParentId, c.IconCss, c.SortOrder));
        }
    }
}
