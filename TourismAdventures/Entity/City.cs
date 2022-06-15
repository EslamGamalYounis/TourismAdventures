﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TourimAdventures.Entity.Entity
{
    [Table("City")]
    public partial class City
    {
        public City()
        {
            Hotels = new HashSet<Hotel>();
            Programs = new HashSet<Program>();
        }

        [Key]
        public Guid Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public Guid CountryId { get; set; }

        [InverseProperty(nameof(Hotel.City))]
        public virtual ICollection<Hotel> Hotels { get; set; }
        [InverseProperty(nameof(Program.City))]
        public virtual ICollection<Program> Programs { get; set; }
    }
}