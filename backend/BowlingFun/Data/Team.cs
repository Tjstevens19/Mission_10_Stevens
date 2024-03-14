using System.ComponentModel.DataAnnotations;

namespace BowlingFun.Data
{
    public class Team
    {
        [Key]
        [Required]
        public int TeamID { get; set; }
        public string? TeamName { get; set; }
        public string? CaptainID { get; set; }
    }
}
