//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tutorsdatabase.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Booking
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Booking time")]
        [DisplayFormat(DataFormatString = "{0:hh:mm:tt}", ApplyFormatInEditMode = true)]
        public System.DateTime Time { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Booking Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public System.DateTime Date { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Booking Duration")]
        [DisplayFormat(DataFormatString = "{0:hh:mm}", ApplyFormatInEditMode = true)]
        public System.DateTime Duration { get; set; }
    }
}