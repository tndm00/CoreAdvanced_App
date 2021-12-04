using AutoMapper;
using AutoMapper.QueryableExtensions;
using CoreAdvanced_App.Application.Interfaces;
using CoreAdvanced_App.Application.ViewModels.Common;
using CoreAdvanced_App.Data.Entities;
using CoreAdvanced_App.Data.IRespositories;
using CoreAdvanced_App.Infrastructure.Interfaces;
using CoreAdvanced_App.Utilities.Constants;
using System.Collections.Generic;
using System.Linq;

namespace CoreAdvanced_App.Application.Implementation
{
    public class CommonService : ICommonService
    {
        private readonly IMapper _mapper;
        private IFooterRepository _footerRepository;
        private ISystemConfigRepository _systemConfigRepository;
        private IUnitOfWork _unitOfWork;
        private ISlideRepository _slideRepository;

        public CommonService(IFooterRepository footerRepository,
            ISystemConfigRepository systemConfigRepository,
            IUnitOfWork unitOfWork,
            ISlideRepository slideRepository,
            IMapper mapper)
        {
            _footerRepository = footerRepository;
            _unitOfWork = unitOfWork;
            _systemConfigRepository = systemConfigRepository;
            _slideRepository = slideRepository;
            _mapper = mapper;
        }

        public FooterViewModel GetFooter()
        {
            return _mapper.Map<Footer, FooterViewModel>(_footerRepository.FindSingle(x => x.Id ==
            SystemConstants.DefaultFooterId));
        }

        public List<SlideViewModel> GetSlides(string groupAlias)
        {
            return _slideRepository.FindAll(x => x.Status && x.GroupAlias == groupAlias)
                .ProjectTo<SlideViewModel>(_mapper.ConfigurationProvider).ToList();
        }

        public SystemConfigViewModel GetSystemConfig(string code)
        {
            return _mapper.Map<SystemConfig, SystemConfigViewModel>(_systemConfigRepository.FindSingle(x => x.Id == code));
        }
    }
}