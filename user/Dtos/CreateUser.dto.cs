using System.ComponentModel.DataAnnotations;

namespace crud.user.Dtos;

public class CreateUserDto
{
    [Required]
    [DataType(DataType.Text)]
    public string Name { get; set; }
    [Required]
    [EmailAddress]
    public string Email { get; set; }
}
