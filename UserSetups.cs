namespace JSON_Converted
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserSetups
    {
        [Key]
        public int UserSetupId { get; set; }

        [Required]
        [StringLength(32)]
        public string UserId { get; set; }

        public int PoolId { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Data { get; set; }

        [Required]
        [StringLength(3)]
        public string CompanyId { get; set; }
    }
}
