using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

public class UserIdentity : IdentityUser
{
    [Key]
    public int UserId { get; set; }

    [Required(ErrorMessage = "Username must be defiend!")]
    public string UserNamee { get; set; } = string.Empty;

    [Required(ErrorMessage = "E-post must be defiend!")]
    public string EPosta { get; set; } = string.Empty;

    [Required(ErrorMessage = "Passaword must be defiend!")]
    public string Passaword { get; set; } = string.Empty;
    [Required(ErrorMessage = "Full name must be defiend!")]
    public string FullName { get; set; } = string.Empty;
    
}