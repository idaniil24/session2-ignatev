//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LopushokApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class products
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public Nullable<double> Article { get; set; }
        public Nullable<double> MinPriceForAgent { get; set; }
        public string Image { get; set; }
        public Nullable<int> ProductType { get; set; }
        public Nullable<int> CounOfMansForCreating { get; set; }
        public Nullable<int> ManifactureID { get; set; }
        public string Description { get; set; }
    
        public virtual ProductsTypes ProductsTypes { get; set; }
    }
}
