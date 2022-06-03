using CoreAdvanced_App.Application.ViewModels.Common;
using CoreAdvanced_App.Application.ViewModels.Order;
using CoreAdvanced_App.Data.Enums;
using CoreAdvanced_App.Utilities.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAdvanced_App.Models.ProductViewModels
{
    public class CheckOutViewModel : BillViewModel
    {
        public List<ShoppingCartViewModel> Carts { get; set; }
        public List<EnumModel> PaymentMethods
        {
            get
            {
                return ((PaymentMethod[])Enum.GetValues(typeof(PaymentMethod)))
                    .Select(c => new EnumModel
                    {
                        Value = (int)c,
                        Name = c.GetDescription()
                    }).ToList();
            }
        }
    }
}
