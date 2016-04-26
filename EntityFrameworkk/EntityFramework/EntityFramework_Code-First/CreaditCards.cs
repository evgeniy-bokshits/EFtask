namespace EntityFramework_Code_First
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CreaditCards
    {
        public int Id { get; set; }

        public int EmployeeId { get; set; }

        [Column(TypeName = "date")]
        public DateTime ExpirationDate { get; set; }

        [Required]
        [StringLength(100)]
        public string CardHolderName { get; set; }

        public virtual Employees Employees { get; set; }
    }
}
