using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Quanlicaan.Models
{
    public class User
    {
        public string id { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 10)]
        public string hoten { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string username { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string password { get; set; }
        [Required]
        public string idphongban { get; set; }
        [Required]
        public bool quyendangki { get; set; }
        [Required]
        public string idchucvu { get; set; }
        [Required]
        public bool trangthai { get; set; }
    }
}