namespace IssueTrackingSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SYSTEM.V_KLIENT")]
    public partial class V_KLIENT
    {
        [StringLength(20)]
        public string LOGIN { get; set; }

        [Key]
        public decimal IDKLIENTA { get; set; }

        [StringLength(30)]
        public string KLIENT { get; set; }

        [StringLength(50)]
        public string ULICA { get; set; }

        [StringLength(30)]
        public string MIASTO { get; set; }

        public short? KOD_POCZTOWY { get; set; }

        [StringLength(30)]
        public string POCZTA { get; set; }

        [StringLength(30)]
        public string EMAIL { get; set; }

        [StringLength(30)]
        public string TELEFON { get; set; }

        [StringLength(30)]
        public string INNY { get; set; }
    }
}
