//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Practice
{
    using System;
    using System.Collections.Generic;
    
    public partial class characteristics
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public characteristics()
        {
            this.engineering = new HashSet<engineering>();
        }
    
        public int CharacteristicsID { get; set; }
        public Nullable<double> Perfomance { get; set; }
        public Nullable<double> EnginePower { get; set; }
        public Nullable<double> InputSize { get; set; }
        public Nullable<double> OutputSize { get; set; }
        public Nullable<double> Weight { get; set; }
        public Nullable<int> GMID { get; set; }
        public Nullable<int> EnTypeID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<engineering> engineering { get; set; }
        public virtual grindingmethod grindingmethod { get; set; }
        public virtual engineeringtype engineeringtype { get; set; }
    }
}
