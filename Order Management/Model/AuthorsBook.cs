//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Order_Management.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class AuthorsBook
    {
        public int AuthorId { get; set; }
        public string ISBN { get; set; }
        public string YearPublished { get; set; }
        public string Edition { get; set; }
    
        public virtual Author Author { get; set; }
        public virtual Book Book { get; set; }
    }
}
