using CoreAdvanced_App.Application.ViewModels.User;
using CoreAdvanced_App.Utilities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoreAdvanced_App.Application.Interfaces
{
    public interface IRoleService
    {
        Task<bool> AddAsync(AppRoleViewModel roleVm);

        Task DeleteAsync(Guid id);

        Task<List<AppRoleViewModel>> GetAllAsync();

        PagedResult<AppRoleViewModel> GetAllPagingAsync(string keyword, int page, int pageSize);

        Task<AppRoleViewModel> GetById(Guid id);


        Task UpdateAsync(AppRoleViewModel userVm);

        List<PermissionViewModel> GetListFunctionWithRole(Guid roleId);

        void SavePermission(List<PermissionViewModel> permissions, Guid roleId);

        Task<bool> CheckPermission(string functionId, string action, string[] roles);
    }
}
