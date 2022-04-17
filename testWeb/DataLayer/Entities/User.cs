﻿using System;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Entities
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        [Display(Name = "Логин")]
        public string Login { get; set; }
        #nullable enable
        public DateTime? LastVisitDate { get; set; }
        [Display(Name = "Email")]
        public string? Email { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Patronimic { get; set; }
        [Display(Name = "ФИО")]
        public string? NameAbbreviation { get; set; }
    }
}
