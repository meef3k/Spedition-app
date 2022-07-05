﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Spedition.Models
{
    public class Trailer
    {
        [Key]
        public int id_trailer { get; set; }
        [Required]
        public string trailer_number { get; set; }
        [Required]
        public string trailer_manufacturer { get; set; }
        [Required]
        public string trailer_model { get; set; }
        [Required]
        public string trailer_plate { get; set; }
        public virtual Package Package { get; set; }
    }
}