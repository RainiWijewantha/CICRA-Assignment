using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class UserDetail
    {

        [Key]
        public int UserDetailId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string UserName { get; set; } = "";

        [Column(TypeName = "nvarchar(120)")]
        public String FullName { get; set; } = "";

        [Column(TypeName = "nvarchar(20)")]
        public String Password { get; set; } = "";
    }
}
