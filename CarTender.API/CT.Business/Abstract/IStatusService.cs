﻿using CarTender.Core.Utilities;
using CT.Business.Abstract.Base;
using CT.Entities.DTOs.Status;
using CT.Entities.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CT.Business.Abstract
{
    public interface IStatusService : IBaseService<Status>
    {
        Task<IDataResult<IEnumerable<ListStatusDTO>>> GetListStatusesByType(string code);
    }
}
