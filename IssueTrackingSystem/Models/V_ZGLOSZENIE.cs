namespace IssueTrackingSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SYSTEM.V_ZGLOSZENIE")]
    public partial class V_ZGLOSZENIE
    {
        public decimal ID { get; set; }

        [StringLength(30)]
        public string KLIENT { get; set; }

        [StringLength(20)]
        public string OPERATOR { get; set; }

        [StringLength(20)]
        public string STATUS { get; set; }

        [StringLength(20)]
        public string PRIORYTET { get; set; }

        [StringLength(200)]
        public string OPIS { get; set; }

        public DateTime? DATA_UTWORZENIA { get; set; }

        public DateTime? DATA_ZAKONCZENIA { get; set; }
    }
}
