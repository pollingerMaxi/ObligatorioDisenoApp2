﻿using Stockapp.Logic.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stockapp.Data;
using Stockapp.Data.Repository;

namespace Stockapp.Logic
{
    public class StockNewsLogic : IStockNewsLogic
    {
        private readonly IUnitOfWork UnitOfWork;

        public StockNewsLogic(IUnitOfWork UnitOfWork)
        {
            this.UnitOfWork = UnitOfWork;
        }

        public bool DeleteStockNews(StockNews news)
        {
            throw new NotImplementedException();
        }

        public bool RegisterStockNews(StockNews news)
        {
            throw new NotImplementedException();
        }
    }
}
