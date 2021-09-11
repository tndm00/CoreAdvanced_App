using AutoMapper;
using AutoMapper.QueryableExtensions;
using CoreAdvanced_App.Application.Interfaces;
using CoreAdvanced_App.Application.ViewModels.Product;
using CoreAdvanced_App.Data.Enums;
using CoreAdvanced_App.Data.IRespositories;
using CoreAdvanced_App.Utilities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreAdvanced_App.Application.Implementation
{
    public class ProductService : IProductService
    {
        private readonly IMapper _mapper;

        private readonly IProductRepository _productRepsitory;
        public ProductService(IProductRepository productRepsitory, IMapper mapper)
        {
            _productRepsitory = productRepsitory;
            _mapper = mapper;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public List<ProductViewModel> GetAll()
        {
            return _productRepsitory.FindAll(_ => _.ProductCategory).ProjectTo<ProductViewModel>(_mapper.ConfigurationProvider).ToList();
        }

        public PagedResult<ProductViewModel> GetAllPaing(int? categoryId, string keyword, int page, int pageSize)
        {
            var query = _productRepsitory.FindAll(_ => _.Status == Status.Active);
            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(_ => _.Name.Contains(keyword));
            }

            if(categoryId.HasValue)
            {
                query = query.Where(_ => _.CategoryId == categoryId);
            }

            int totalRow = query.Count();

            query = query.OrderByDescending(_ => _.DateCreated)
                .Skip((page - 1) * pageSize).Take(pageSize);

            var data = query.ProjectTo<ProductViewModel>(_mapper.ConfigurationProvider).ToList();

            var paginationSet = new PagedResult<ProductViewModel>()
            {
                Results = data,
                CurrentPage = page,
                RowCount = totalRow,
                PageSize = pageSize
            };

            return paginationSet;
        }
    }
}
