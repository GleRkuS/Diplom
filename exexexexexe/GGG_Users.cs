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
    
    public partial class GGG_Users
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GGG_Users()
        {
            this.GGG_Stroi_Ob = new HashSet<GGG_Stroi_Ob>();
        }
    
        public int ID { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string role { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GGG_Stroi_Ob> GGG_Stroi_Ob { get; set; }
    }
}
