namespace ProfileTeamProject.ModelData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class InvoiceDetail
    {
        [Key]
        public int InvoiceDetailsID { get; set; }

        public int InvoiceID { get; set; }

        public int ProductID { get; set; }

        [Required]
        [StringLength(50)]
        public string ProductName { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public virtual Invoice Invoice { get; set; }

        public virtual Product Product { get; set; }
    }
}
