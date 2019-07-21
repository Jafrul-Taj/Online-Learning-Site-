using EntityFrameWorkCorePractice.Models.Data;
using System.ComponentModel.DataAnnotations;

namespace EntityFrameWorkCorePractice
{
    public class Course
    {
        [Key,Required]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public int SiteUserId { get; set; }
        public SiteUser  SiteUser { get; set; }
    }
}