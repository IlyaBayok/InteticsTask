//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace service_station.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Order
    {
        [Required]
        public int IdCar { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        [Range(0,10000)]
        public decimal OrderAmount { get; set; }
        [Required]
        public string OrderStatus { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public System.DateTime Date { get; set; }
    
        public virtual Car Car { get; set; }
    }
}
