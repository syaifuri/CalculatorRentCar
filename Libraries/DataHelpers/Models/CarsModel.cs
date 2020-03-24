using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraries.DataHelpers.Models
{
   public class CarsModel
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string ModelName { get; set; }
        public string SeriesName { get; set; }
        public int ModelYear { get; set; }
        public string NumberCar { get; set; }
        public string CreateDate { get; set; }  // use string format "YYYY-MM-DD HH:MM:SS.SSS" for sqlite
    }
}
