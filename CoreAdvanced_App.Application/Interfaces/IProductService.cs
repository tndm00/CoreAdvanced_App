using CoreAdvanced_App.Application.ViewModels.Product;
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

        ProductViewModel Add(ProductViewModel product);

        void Update(ProductViewModel product);

        void Delete(int id);

        ProductViewModel GetById(int id);

        void ImportExcel(string filePath, int categoryId);

        void Save();

        void AddQuantity(int productId, List<ProductQuantityViewModel> quantities);

        List<ProductQuantityViewModel> GetQuantities(int productId);

        void AddImages(int productId, string[] images);

        List<ProductImageViewModel> GetImages(int productId);

        void AddWholePrice(int productId, List<WholePriceViewModel> wholePrices);

        List<WholePriceViewModel> GetWholePrices(int productId);

        List<ProductViewModel> GetLastest(int top);

        List<ProductViewModel> GetHotProduct(int top);
    }
}
