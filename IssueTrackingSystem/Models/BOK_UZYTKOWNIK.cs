namespace IssueTrackingSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SYSTEM.BOK_UZYTKOWNIK")]
    public partial class BOK_UZYTKOWNIK
    {
        [Key]
        public decimal ID_UZYTKOWNIK { get; set; }

        public decimal? ID_KLIENTA { get; set; }

        public decimal? ID_OPERATOR { get; set; }

        [StringLength(20)]
        public string LOGIN { get; set; }

        [StringLength(64)]
        public string PASSWORD_HASH { get; set; }

        public bool? AKTYWNY { get; set; }

        public virtual BOK_KLIENT BOK_KLIENT { get; set; }

        public virtual BOK_OPERATOR BOK_OPERATOR { get; set; }
    }
}
