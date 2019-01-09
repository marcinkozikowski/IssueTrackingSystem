namespace IssueTrackingSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SYSTEM.BOK_ADRES")]
    public partial class BOK_ADRES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOK_ADRES()
        {
            BOK_KLIENT = new HashSet<BOK_KLIENT>();
        }

        [Key]
        public decimal ID_ADRES { get; set; }

        [StringLength(50)]
        public string ULICA { get; set; }

        [StringLength(30)]
        public string MIASTO { get; set; }

        public short? KOD_POCZTOWY { get; set; }

        [StringLength(30)]
        public string POCZTA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOK_KLIENT> BOK_KLIENT { get; set; }
    }
}
