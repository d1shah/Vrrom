using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace vroom.Models
{
    public class Features
    {
      
        public int Id { get; set; }
  [Required]
        [StringLength(25)]
        public string Name { get; set; }
        public ICollection<Model> Models { get; set; }
    }
}



