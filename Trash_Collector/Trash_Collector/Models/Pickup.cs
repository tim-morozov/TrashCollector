using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Trash_Collector.Models
{
    public class Pickup
    {
        [Key]
        public int Id { get; set; }
        public string Day { get; set; }
        public bool IsPickedUp { get; set; }
        

        ///////
        //[ForeignKey("Customer")]
        //public int CustomerId { get; set; }
        //public Customer Customer { get; set; }
    }
}
