using Crito.Contexts;
using Crito.Models;
using Crito.Models.Entities;

namespace Crito.Services;

public class ContactService
{
    private readonly DataContext _dataContext;

    public ContactService(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    public async Task<ContactEntity> CreateAsync(ContactModel model)
    {
        try
        {
            ContactEntity contactEntity = model;
            _dataContext.Add(contactEntity);
            await _dataContext.SaveChangesAsync();
            return contactEntity;
        }
        catch { return null!; }
    }

}
