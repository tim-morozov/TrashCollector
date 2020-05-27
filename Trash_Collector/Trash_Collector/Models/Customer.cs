using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Trash_Collector.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [Display(Name="Zip Code")]
        public int ZipCode { get; set; }
        [Display(Name="Street Address")]
        public string StreetAddress { get; set; }
        public double Balance { get; set; }
        [Display(Name ="One-Time Pickup")]
        public DateTime? OneTime { get; set; }
      
        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }

        [NotMapped]
        public List<Pickup> Pickups { get; set; }

        
        ////////////
        
        [ForeignKey("Pickup")]
        public int PickUpId { get; set; }
        public Pickup Pickup { get; set; }
    }
}
