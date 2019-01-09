namespace IssueTrackingSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SYSTEM.BOK_DANE_KONTAKTOWE")]
    public partial class BOK_DANE_KONTAKTOWE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOK_DANE_KONTAKTOWE()
        {
            BOK_KLIENT = new HashSet<BOK_KLIENT>();
        }

        [Key]
        public decimal ID_DANE_KONTAKTOWE { get; set; }

        [StringLength(30)]
        public string EMAIL { get; set; }

        [StringLength(30)]
        public string TELEFON { get; set; }

        [StringLength(30)]
        public string INNY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOK_KLIENT> BOK_KLIENT { get; set; }
    }
}
