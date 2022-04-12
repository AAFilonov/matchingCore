using System.ComponentModel.DataAnnotations;

namespace DataLayer.Entities
{
    #nullable enable
    public class Tutor
    {
        [Key]
        public int TutorID { get; set; }
        public string? TutorNameAbbreviation { get; set; }
    }
}