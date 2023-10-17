﻿using System.ComponentModel.DataAnnotations;

namespace PeliculasAPI.DTO
{
    public class ActorCreacionDTO
    {

        [Required]
        [StringLength(maximumLength: 200)]
        public string Nombre { get; set; }
        public string Biografia { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public IFormFile Foto { get; set; }
    }
}