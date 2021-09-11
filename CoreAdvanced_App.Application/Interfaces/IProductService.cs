﻿using CoreAdvanced_App.Application.ViewModels.Product;
using CoreAdvanced_App.Utilities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreAdvanced_App.Application.Interfaces
{
    public interface IProductService : IDisposable
    {
        List<ProductViewModel> GetAll();

        PagedResult<ProductViewModel> GetAllPaing(int? categoryId, string keyword, int page, int pageSize);
    }
}
