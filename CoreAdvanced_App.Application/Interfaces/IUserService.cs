using CoreAdvanced_App.Application.ViewModels.User;
using CoreAdvanced_App.Utilities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoreAdvanced_App.Application.Interfaces
{
    public interface IUserService
    {
        Task<bool> AddAsync(AppUserViewModel userVm);

        Task DeleteAsync(string id);

        Task<List<AppUserViewModel>> GetAllAsync();

        PagedResult<AppUserViewModel> GetAllPagingAsync(string keyword, int page, int pageSize);

        Task<AppUserViewModel> GetById(string id);


        Task UpdateAsync(AppUserViewModel userVm);
    }
}
