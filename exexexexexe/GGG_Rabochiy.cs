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
    
    public partial class GGG_Rabochiy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GGG_Rabochiy()
        {
            this.GGG_Zadanie_Rabochi = new HashSet<GGG_Zadanie_Rabochi>();
        }
    
        public int ID { get; set; }
        public string Imya { get; set; }
        public string Familiya { get; set; }
        public string Otchestvo { get; set; }
        public string Telefon { get; set; }
        public Nullable<int> Nom_Brig { get; set; }
        public string Napravlenie { get; set; }
    
        public virtual GGG_Brigada GGG_Brigada { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GGG_Zadanie_Rabochi> GGG_Zadanie_Rabochi { get; set; }
    }
}
