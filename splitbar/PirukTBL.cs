//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace splitbar
{
    using System;
    using System.Collections.Generic;
    
    public partial class PirukTBL
    {
        public int id { get; set; }
        public string Makat { get; set; }
        public string Des { get; set; }
        public string TypeWeight { get; set; }
        public Nullable<double> Weight { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> WorkerId { get; set; }
        public string WorkerName { get; set; }
        public Nullable<double> TaraWeight { get; set; }
        public string TaraName { get; set; }
        public string ParentMakat { get; set; }
    }
}