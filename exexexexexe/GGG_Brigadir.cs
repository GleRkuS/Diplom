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
    
    public partial class GGG_Brigadir
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GGG_Brigadir()
        {
            this.GGG_Zadanie_Brigadir = new HashSet<GGG_Zadanie_Brigadir>();
        }
    
        public int ID { get; set; }
        public Nullable<int> Nom_Brig { get; set; }
        public string Imya { get; set; }
        public string Familiya { get; set; }
        public string Otchestvo { get; set; }
    
        public virtual GGG_Brigada GGG_Brigada { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GGG_Zadanie_Brigadir> GGG_Zadanie_Brigadir { get; set; }
    }
}
