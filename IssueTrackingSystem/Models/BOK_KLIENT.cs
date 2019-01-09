namespace IssueTrackingSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SYSTEM.BOK_KLIENT")]
    public partial class BOK_KLIENT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOK_KLIENT()
        {
            BOK_UZYTKOWNIK = new HashSet<BOK_UZYTKOWNIK>();
            BOK_ZGLOSZENIE = new HashSet<BOK_ZGLOSZENIE>();
        }

        [Key]
        public decimal ID_KLIENTA { get; set; }

        public decimal? ID_DANE_KONTAKTOWE { get; set; }

        public decimal? ID_ADRES { get; set; }

        [StringLength(30)]
        public string NAZWA { get; set; }

        public virtual BOK_ADRES BOK_ADRES { get; set; }

        public virtual BOK_DANE_KONTAKTOWE BOK_DANE_KONTAKTOWE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOK_UZYTKOWNIK> BOK_UZYTKOWNIK { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOK_ZGLOSZENIE> BOK_ZGLOSZENIE { get; set; }
    }
}
