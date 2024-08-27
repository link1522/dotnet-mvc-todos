using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class User
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [MaxLength(255)]
    public string? Username { get; set; }

    [Required]
    [MaxLength(255)]
    public string? Email { get; set; }

    [Required]
    [MaxLength(255)]
    public string? Password { get; set; }
}