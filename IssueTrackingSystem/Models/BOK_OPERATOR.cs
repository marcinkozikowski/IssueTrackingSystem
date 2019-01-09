namespace IssueTrackingSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SYSTEM.BOK_OPERATOR")]
    public partial class BOK_OPERATOR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOK_OPERATOR()
        {
            BOK_ODPOWIEDZ = new HashSet<BOK_ODPOWIEDZ>();
            BOK_UZYTKOWNIK = new HashSet<BOK_UZYTKOWNIK>();
            BOK_ZGLOSZENIE = new HashSet<BOK_ZGLOSZENIE>();
        }

        [Key]
        public decimal ID_OPERATOR { get; set; }

        [StringLength(20)]
        public string NAZWA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOK_ODPOWIEDZ> BOK_ODPOWIEDZ { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOK_UZYTKOWNIK> BOK_UZYTKOWNIK { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOK_ZGLOSZENIE> BOK_ZGLOSZENIE { get; set; }
    }
}
