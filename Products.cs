namespace JSON_Converted
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Products
    {
        [Key]
        public int ProductId { get; set; }

        [StringLength(500)]
        public string Name { get; set; }

        [StringLength(50)]
        public string ProductRefId { get; set; }

        public int PoolId { get; set; }

        public decimal Price { get; set; }

        public bool ShowGroups { get; set; }

        [Required]
        [StringLength(3)]
        public string CurrencyId { get; set; }

        public bool Enabled { get; set; }

        public DateTime ModifiedDateTime { get; set; }

        [StringLength(50)]
        public string ProductGroupId { get; set; }

        public decimal DefaultMarkup { get; set; }

        public decimal Alp2Dac { get; set; }

        public decimal Rrp { get; set; }

        [Required]
        [StringLength(50)]
        public string PartNumber { get; set; }

        public int Order { get; set; }
    }
}
