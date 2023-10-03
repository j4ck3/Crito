using Crito.Models.Entities;
using System.ComponentModel.DataAnnotations;

namespace Crito.Models;

public class NewsLetterSignupModel
{
    [EmailAddress]
    [Required]
    public string Email { get; set; } = null!;

    public static implicit operator NewsLetterSignupEntity(NewsLetterSignupModel model)
    {
        return new NewsLetterSignupEntity()
        {
            Email = model.Email,
        };
    }
}
