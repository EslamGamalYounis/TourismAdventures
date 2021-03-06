// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TourimAdventures.Entity.Entity
{
    [Table("Trip")]
    public partial class Trip
    {
        public Trip()
        {
            TripProgramActivities = new HashSet<TripProgramActivity>();
        }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Cost { get; set; }
        [StringLength(50)]
        public string Status { get; set; }
        public int? NoOfTicket { get; set; }
        public int? AvailSeat { get; set; }
        public int? Duration { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EndDate { get; set; }
        public string Description { get; set; }
        [Key]
        public Guid Id { get; set; }
        public Guid CountryId { get; set; }

        [ForeignKey(nameof(CountryId))]
        [InverseProperty("Trips")]
        public virtual Country Country { get; set; }
        [InverseProperty(nameof(TripProgramActivity.Trip))]
        public virtual ICollection<TripProgramActivity> TripProgramActivities { get; set; }
    }
}