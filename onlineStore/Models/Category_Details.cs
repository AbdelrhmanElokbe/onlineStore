using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace onlineStore.Models
{
    public class Category_Details
    {
        public int categoryId { get; set; }
        [Required(ErrorMessage ="Category name is required!")]
        [StringLength(100, ErrorMessage = "Minimum 3, and maximum 100 chars are allowed"), MinLength(3)]
        public string CategoryName { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDelete { get; set; }
    }
}