using System.ComponentModel.DataAnnotations;

namespace SecondAPIs.Models
{
    public class Videos
    {
        [Key]
        public int VideoId;
        [Required]
        public string VideoName;


    }
}
