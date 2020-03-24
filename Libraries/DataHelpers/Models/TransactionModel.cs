using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraries.DataHelpers.Models
{
   public class TransactionModel
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Car { get; set; }
        public int ModelYear { get; set; }
        public int QtyCar { get; set; }
        public int TotalDay { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalPrice { get; set; }
        public string CreateDate { get; set; }  // use string format "YYYY-MM-DD HH:MM:SS.SSS" for sqlite

    }
}
