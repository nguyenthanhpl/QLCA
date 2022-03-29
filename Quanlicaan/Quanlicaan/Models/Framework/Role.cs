namespace Quanlicaan
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Role
    {
        public int ID { get; set; }

        

        [Required]
        [StringLength(25)]
        public string URole { get; set; }
        
    }
}
