using BookShop.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Domain.Model
{
    public abstract class BaseEntity
    {
        [Key]
        [DatabaseGenerated(databaseGeneratedOption: DatabaseGeneratedOption.Identity)]
        [Column(TypeName ="numeric(18,0)")]
        public decimal Id { get; set; }
        public DateTime InsertDate { get; set; }=DateTime.Now;
        public DateTime EditTime { get; set; } = DateTime.Now;
        public EnumActiveOrNot IsActive { get; set; }

    }
}
