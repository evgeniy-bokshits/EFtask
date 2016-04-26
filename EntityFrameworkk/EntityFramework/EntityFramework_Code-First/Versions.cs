namespace EntityFramework_Code_First
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Versions
    {
        [Key]
        public decimal Vers { get; set; }
    }
}
