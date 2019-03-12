using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using System.Linq;
using System.Web;

namespace MVCDemoApp.Models
{
    public class Restaurant
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }

        public string City { get; set; }

        // Navigation Property
        public List<Review> Reviews { get; set; }
    }
}