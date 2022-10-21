﻿using CT.DataAccess.Abstract;
using CT.DataAccess.Concrete.Dapper.Base;
using CT.DataAccess.Context;
using CT.Entities.Entities;

namespace CT.DataAccess.Concrete.Dapper
{
    public class BidDAL : DapperRepository<Bid,CarTenderDbContext>, IBidDAL
    {
    }
}
