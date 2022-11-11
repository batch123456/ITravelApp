using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TravelProjectAPI.Models
{
    public class Comments
    {
        [Key]
        public int CommentId { get; set; } 
        public string CommentText { get; set; }
        public DateTime Created { get; set; }
        public int UerId { get; set; }  
        public int TravelId { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        [ForeignKey("TravelId")]
        public virtual TravelDetails TravelDetails { get; set; }
    }
}