using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirst_01.Models
{
    public class OrderDetail
    {

        [Key]
        public int OrderDetailID { get; set; }
        public int ProductID { get; set; }
        public int OrderID { get; set; }
        public OrderMaster OrderMaster { get; set; }

        public int Quantity { get; set; }

        public decimal Rate { get; set; }
    }
}