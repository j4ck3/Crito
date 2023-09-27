namespace Crito.Models.Entities;

public class ContactEntity
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Name { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Message { get; set; } = null!;
    public DateTime SentDate { get; set; } = DateTime.Now;

    public static implicit operator ContactModel(ContactEntity entity)
    {
        return new ContactModel
        {
            Id = entity.Id,
            Name = entity.Name,
            Email = entity.Email,
            Message = entity.Message,
            SentDate = entity.SentDate,
        };
    }
}
