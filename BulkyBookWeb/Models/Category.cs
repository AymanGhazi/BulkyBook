using System;
using System.ComponentModel.DataAnnotations;

namespace BulkyBookWeb.Models
{
    public class Category
    {
        [Required]
        [Key]//primary Key
        public int Id { get; set; }

        [Required]

        public string Name { get; set; }

        [Display(Name = "Display Order")]
        [Range(1, 1000, ErrorMessage = "Display Order must be from 1 to 1000")]
        public int DisplayOrder { get; set; }

        public DateTime CreatedDateTime { get; set; } = DateTime.Now;

    }
}