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
    
    public partial class ParamTBL
    {
        public int id { get; set; }
        public string TermNum { get; set; }
        public string COM1 { get; set; }
        public string CommunicationRate1 { get; set; }
        public string COM2 { get; set; }
        public string CommunicationRate2 { get; set; }
        public Nullable<bool> WorkWithOneWeight { get; set; }
        public string Printer { get; set; }
        public Nullable<int> NumCopy { get; set; }
        public Nullable<bool> KosherToPesach { get; set; }
        public string KosherToPesachText { get; set; }
        public Nullable<bool> Kashrut { get; set; }
        public string KashrutText { get; set; }
        public string FreeTextForMadbeka { get; set; }
        public Nullable<bool> IsAriza { get; set; }
        public Nullable<bool> IsArkava { get; set; }
        public Nullable<bool> MinusInWeight { get; set; }
        public Nullable<bool> IsSumArkava { get; set; }
        public Nullable<bool> ChangeDatePagOrExpiryDate { get; set; }
    }
}