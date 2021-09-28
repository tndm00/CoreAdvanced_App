﻿using CoreAdvanced_App.Data.Entities;
using CoreAdvanced_App.Infrastructure.Interfaces;

namespace CoreAdvanced_App.Data.IRespositories
{
    public interface IColorRepository : IRepository<Color, int>
    {
    }
}