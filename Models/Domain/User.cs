using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EfCoreLearning.Models.Domain
{
    [Index(nameof(EmailId), IsUnique = true)]
    [Index(nameof(MobileNo), IsUnique = true)]
    [Index(nameof(UserName), IsUnique = true)]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; } = string.Empty;
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int MobileNo { get; set; }
        [Required]
        public string EmailId { get; set; } = string.Empty;
        public bool IsEmailConfirmed { get; set; } = false;
        public DateTime RegisteredOn { get; set; }
        public DateTime LastLogin { get; set; }
        public string Intro { get; set; } = string.Empty;
        public string profile { get; set; } = string.Empty;
        public int RoleId { get; set; }

    }
}
