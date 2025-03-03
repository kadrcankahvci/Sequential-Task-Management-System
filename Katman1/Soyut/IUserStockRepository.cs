﻿using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.Soyut
{
    public interface IUserStockRepository : IRepository<UserStock>
    {
        bool Exists(UserStock userstock);
    }
}
