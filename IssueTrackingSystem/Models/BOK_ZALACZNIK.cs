namespace IssueTrackingSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SYSTEM.BOK_ZALACZNIK")]
    public partial class BOK_ZALACZNIK
    {
        [Key]
        public decimal ID_ZALACZNIK { get; set; }

        public decimal? ID_ZGLOSZENIA { get; set; }

        public byte[] TRESC { get; set; }

        public virtual BOK_ZGLOSZENIE BOK_ZGLOSZENIE { get; set; }
    }
}
