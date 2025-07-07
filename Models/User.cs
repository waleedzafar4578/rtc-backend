using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RTC.Models
{
  [Table("[user]")]
  public class User
  {
    [Key]
    [Column("id")]
    public int UserId { get; set; }

    [Column("username")]
    public string Username { get; set; }

    [Column("email")]
    public string Email { get; set; }

    [Column("phoneno")]
    public string PhoneNo { get; set; }

    [Column("firstname")]
    public string FirstName { get; set; }

    [Column("lastname")]
    public string LastName { get; set; }

    [Column("profilepicture")]
    public string ProfilePicture { get; set; }

    [Column("password")]
    public string Password { get; set; }

    [Column("role")]
    public string Role { get; set; }
  }
}