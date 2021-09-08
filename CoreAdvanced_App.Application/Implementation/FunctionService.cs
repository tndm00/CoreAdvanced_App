using AutoMapper;
using AutoMapper.QueryableExtensions;
using CoreAdvanced_App.Application.Interfaces;
using CoreAdvanced_App.Application.ViewModels.System;
using CoreAdvanced_App.Data.IRespositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoreAdvanced_App.Application.Implementation
{
    public class FunctionService : IFunctionService
    {
        private readonly IFunctionRepository _functionRepository;
        private readonly IMapper _mapper;

        public FunctionService(IFunctionRepository functionRepository,
            IMapper mapper)
        {
            _functionRepository = functionRepository;
            _mapper = mapper;
        }

        public void Dispose()
        {
            //Destroy the current object
            GC.SuppressFinalize(this);
        }

        public async Task<List<FunctionViewModel>> GetAll()
        {
            return await _functionRepository.FindAll()
                .ProjectTo<FunctionViewModel>(_mapper.ConfigurationProvider).ToListAsync();
        }

        public List<FunctionViewModel> GetAllByPermission(Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}