namespace IssueTrackingSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SYSTEM.BOK_ODPOWIEDZ")]
    public partial class BOK_ODPOWIEDZ
    {
        [Key]
        public decimal ID_ODPOWIEDZI { get; set; }

        public decimal? ID_ZGLOSZENIE { get; set; }

        public decimal? ID_OPERATOR { get; set; }

        [StringLength(200)]
        public string OPIS { get; set; }

        public DateTime? DATA_ODPOWIEDZI { get; set; }

        public virtual BOK_ZGLOSZENIE BOK_ZGLOSZENIE { get; set; }

        public virtual BOK_OPERATOR BOK_OPERATOR { get; set; }
    }
}
