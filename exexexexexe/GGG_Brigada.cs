//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace exexexexexe
{
    using System;
    using System.Collections.Generic;
    
    public partial class GGG_Brigada
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GGG_Brigada()
        {
            this.GGG_Brigadir = new HashSet<GGG_Brigadir>();
            this.GGG_Rabochiy = new HashSet<GGG_Rabochiy>();
        }
    
        public int ID { get; set; }
        public Nullable<int> Brigadir { get; set; }
        public string Nazvanie { get; set; }
        public Nullable<int> Stroi_Ob { get; set; }
    
        public virtual GGG_Stroi_Ob GGG_Stroi_Ob { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GGG_Brigadir> GGG_Brigadir { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GGG_Rabochiy> GGG_Rabochiy { get; set; }
    }
}
