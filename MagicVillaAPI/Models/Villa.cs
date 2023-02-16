﻿using System.ComponentModel.DataAnnotations;

namespace MagicVillaAPI.Models
{
    public class Villa
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
    }
}
