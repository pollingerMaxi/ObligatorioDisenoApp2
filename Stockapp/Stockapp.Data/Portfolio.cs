﻿using Stockapp.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stockapp.Data
{
    public class Portfolio: ISoftDelete
    {
        public Guid Id { get; set; }

        public Guid PlayerId { get; set; }

        public virtual Player Player { get; set; }

        public double AvailableMoney { get; set; }

        public double ActionsValue { get; set; }

        public virtual IEnumerable<Transaction> Transactions { get; set; }

        public bool IsDeleted { get; set; }
    }
}
