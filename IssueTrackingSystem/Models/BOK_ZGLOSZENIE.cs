namespace IssueTrackingSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SYSTEM.BOK_ZGLOSZENIE")]
    public partial class BOK_ZGLOSZENIE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOK_ZGLOSZENIE()
        {
            BOK_ODPOWIEDZ = new HashSet<BOK_ODPOWIEDZ>();
            BOK_ZALACZNIK = new HashSet<BOK_ZALACZNIK>();
        }

        [Key]
        public decimal ID_ZGLOSZENIE { get; set; }

        public decimal? ID_KLIENTA { get; set; }

        public decimal? ID_OPERATOR { get; set; }

        public decimal? ID_STATUS { get; set; }

        public decimal? ID_PRIORYTET { get; set; }

        [StringLength(200)]
        public string OPIS { get; set; }

        public DateTime? DATA_UTWORZENIA { get; set; }

        public DateTime? DATA_ZAKONCZENIA { get; set; }

        public virtual BOK_KLIENT BOK_KLIENT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOK_ODPOWIEDZ> BOK_ODPOWIEDZ { get; set; }

        public virtual BOK_OPERATOR BOK_OPERATOR { get; set; }

        public virtual BOK_PRIORYTET BOK_PRIORYTET { get; set; }

        public virtual BOK_STATUS BOK_STATUS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOK_ZALACZNIK> BOK_ZALACZNIK { get; set; }
    }
}
