// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TourimAdventures.Entity.Entity
{
    [Table("Country")]
    public partial class Country
    {
        public Country()
        {
            Trips = new HashSet<Trip>();
        }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Key]
        public Guid Id { get; set; }

        [InverseProperty(nameof(Trip.Country))]
        public virtual ICollection<Trip> Trips { get; set; }
    }
}