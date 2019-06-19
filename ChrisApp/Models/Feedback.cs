using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChrisApp.Models
{
    public class Feedback
    {
        [BindNever]
        public int FeedbackId { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [Required]
        [StringLength(100, ErrorMessage ="Email is required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [StringLength(1500, ErrorMessage = "Message is required")]
        public string Message { get; set; }

        public bool ContactMe { get; set; }
    }
}
