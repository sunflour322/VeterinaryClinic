//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VeterinaryClinic.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pets
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pets()
        {
            this.Record = new HashSet<Record>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public Nullable<int> pet_type_id { get; set; }
        public Nullable<int> age { get; set; }
        public Nullable<int> client_id { get; set; }
    
        public virtual Clients Clients { get; set; }
        public virtual Pet_Types Pet_Types { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Record> Record { get; set; }
    }
}
