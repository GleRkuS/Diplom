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
    
    public partial class GGG_Stroi_Ob
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GGG_Stroi_Ob()
        {
            this.GGG_Brigada = new HashSet<GGG_Brigada>();
        }
    
        public int ID { get; set; }
        public string Nazvanie { get; set; }
        public string Adress { get; set; }
        public Nullable<int> Users { get; set; }
        public Nullable<int> Prorab { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GGG_Brigada> GGG_Brigada { get; set; }
        public virtual GGG_Prorab GGG_Prorab { get; set; }
        public virtual GGG_Users GGG_Users { get; set; }
    }
}