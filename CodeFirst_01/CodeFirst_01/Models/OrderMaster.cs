using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirst_01.Models
{
    public class OrderMaster
    {
        [Key]
        public int OrderID { get; set; }
        public string OrderNo { get; set; }

        public DateTime OrderDate { get; set; }

        public string Description { get; set; }

        public string AddressProofImage { get; set; }

        public Nullable<bool> Terms { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}