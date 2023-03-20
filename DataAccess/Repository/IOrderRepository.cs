﻿using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderRepository
    {
        void addOrder(Order order);
        void editOrder(Order order);
        void deleteOrder(Order order);
    }
}
