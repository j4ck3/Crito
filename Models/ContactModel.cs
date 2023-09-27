using Crito.Models.Entities;
using System.ComponentModel.DataAnnotations;

namespace Crito.Models;

public class ContactModel
{
    public string? Id { get; set; }

	[EmailAddress]
    [Required(ErrorMessage = "*")]
    public string Email { get; set; } = null!;

    [Required(ErrorMessage = "*")]
    public string Name { get; set; } = null!;

    [Required(ErrorMessage = "*")]
    public string Message { get; set; } = null!;
    public DateTime SentDate { get; set; }


    public static implicit operator ContactEntity(ContactModel model)
    {
        return new ContactEntity
        {
            Name = model.Name,
            Email = model.Email,
            Message = model.Message,
        };
    }
}
