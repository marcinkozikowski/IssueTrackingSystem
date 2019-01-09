namespace IssueTrackingSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SYSTEM.BOK_STATUS")]
    public partial class BOK_STATUS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOK_STATUS()
        {
            BOK_ZGLOSZENIE = new HashSet<BOK_ZGLOSZENIE>();
        }

        [Key]
        public decimal ID_STATUS { get; set; }

        [StringLength(20)]
        public string OPIS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOK_ZGLOSZENIE> BOK_ZGLOSZENIE { get; set; }
    }
}
