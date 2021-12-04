using CoreAdvanced_App.Application.ViewModels.Common;
using System.Collections.Generic;

namespace CoreAdvanced_App.Application.Interfaces
{
    public interface ICommonService
    {
        FooterViewModel GetFooter();

        List<SlideViewModel> GetSlides(string groupAlias);

        SystemConfigViewModel GetSystemConfig(string code);
    }
}