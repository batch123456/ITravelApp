using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelAPI.Models
{
    public class ForgotPswd
    {
        [Key]
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}