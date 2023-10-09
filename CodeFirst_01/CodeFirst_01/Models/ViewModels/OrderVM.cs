using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirst_01.Models.ViewModels
{
    public class OrderVM
    {
        public int OrderDetailID { get; set; }
        public int ProductID { get; set; }
        public int OrderID { get; set; }

        public int Quantity { get; set; }
        [Required]
        public decimal Rate { get; set; }
        [Required]
        public string OrderNo { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime OrderDate { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        public string AddressProofImage { get; set; }

        public Nullable<bool> Terms { get; set; }
    }
}