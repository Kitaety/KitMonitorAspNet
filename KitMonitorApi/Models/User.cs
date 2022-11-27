using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KitMonitorApi.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string HashPassword { get; set; }
        public UserRoleEnum Role { get; set; }
        public Organization? Organization { get; set; }
    }

    public enum UserRoleEnum
    {
        SuperAdmin,
        Admin,
        Viewer
    }
}
