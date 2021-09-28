using CoreAdvanced_App.Application.ViewModels.Order;
using CoreAdvanced_App.Application.ViewModels.Product;
using CoreAdvanced_App.Data.Enums;
using CoreAdvanced_App.Utilities.Dtos;
using System.Collections.Generic;

namespace CoreAdvanced_App.Application.Interfaces
{
    public interface IBillService
    {
        void Create(BillViewModel billVm);

        void Update(BillViewModel billVm);

        PagedResult<BillViewModel> GetAllPaging(string startDate, string endDate, string keyword,
            int pageIndex, int pageSize);

        BillViewModel GetDetail(int billId);

        BillDetailViewModel CreateDetail(BillDetailViewModel billDetailVm);

        void DeleteDetail(int productId, int billId, int colorId, int sizeId);

        void UpdateStatus(int orderId, BillStatus status);

        List<BillDetailViewModel> GetBillDetails(int billId);

        List<ColorViewModel> GetColors();

        List<SizeViewModel> GetSizes();

        void ConfirmBill(int billId);

        void PendingBill(int billId);

        void CancelBill(int billId);

        void Save();
    }
}