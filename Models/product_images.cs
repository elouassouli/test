//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EcommerceSite.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class product_images
    {
        public int id { get; set; }
        public string smallSize { get; set; }
        public string mediumSize { get; set; }
        public string largeSize { get; set; }
        public Nullable<int> product { get; set; }
    
        public virtual product product1 { get; set; }
    }
}
