using Crito.Models.Entities;
using System.ComponentModel.DataAnnotations;

namespace Crito.Models;

public class NewsLetterSignupModel
{
    [Required(ErrorMessage = "Ange en mail adress")]
    public string Email { get; set; }


    public static implicit operator NewsLetterSignupEntity(NewsLetterSignupModel model)
    {
        return new NewsLetterSignupEntity()
        {
            Email = model.Email,
        };
    }
}
