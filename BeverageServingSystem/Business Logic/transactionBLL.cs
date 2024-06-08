﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageServingSystem.Business_Logic
{
    class transactionBLL
    {
        public int id { get; set; }

        public string type { get; set; }

        public int cust_id { get; set; }

        public decimal grandtotal { get; set; }

        public DateTime transction_date { get; set; }

        public decimal tax { get; set; }

        public decimal discount { get; set; }

        public int added_by { get; set; }

        public DataTable transactionDetails{ get; set; }

    }
}
