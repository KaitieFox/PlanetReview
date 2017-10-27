using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PlanetReview.Models
{
    public class Review
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "Review Summary"), MaxLength(50)]
        public string Title { get; set; }
        [MaxLength(500)]
        public string Content { get; set; }
        public DateTime PublishDate { get; set; }
        [Range(1, 5)]
        public int Rating { get; set; }

        [ForeignKey("Category") Display(Name = "Planets")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}