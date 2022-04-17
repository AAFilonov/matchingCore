﻿using System.ComponentModel.DataAnnotations;

namespace DataLayer.Entities
{
    #nullable enable
    public class Group
    {
        [Key]
        public int GroupID { get; set; }
        public string? GroupName { get; set; }
    }
}
