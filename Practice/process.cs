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
    
    public partial class process
    {
        public int EnID { get; set; }
        public int MatID { get; set; }
        public Nullable<bool> Abiity { get; set; }
    
        public virtual engineering engineering { get; set; }
        public virtual material material { get; set; }
    }
}
