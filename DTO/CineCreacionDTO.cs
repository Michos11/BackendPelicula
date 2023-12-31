﻿using System.ComponentModel.DataAnnotations;

namespace PeliculasAPI.DTO
{
    public class CineCreacionDTO
    {
        [Required]
        [StringLength(maximumLength: 75)]
        public string Nombre { get; set; }
       
        [Range(-90,90)]
        public double Latitud {  get; set; }
        
        [Range(-500, 500)]
        public double Longitud { get; set;}
    }
}
