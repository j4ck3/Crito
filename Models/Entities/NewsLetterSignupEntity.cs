using System.ComponentModel.DataAnnotations;
namespace Crito.Models.Entities;

public class NewsLetterSignupEntity
{
	[Key]
	public string Email { get; set; } = null!;
}