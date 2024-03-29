﻿using BulkyBookV2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BulkyBookV2.DataAccess.Repository.IRepository
{
    public interface IOrderDetailsRepository : IRepository<OrderDetails>
    {
        void Update(OrderDetails obj);
    }
}
