using Crito.Contexts;
using Crito.Models;
using Crito.Models.Entities;
namespace Crito.Services;

public class NewsSignupService
{
    private readonly DataContext _dataContext;

    public NewsSignupService(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    public async Task<bool> CreateAsync(NewsLetterSignupModel model)
    {
        try
        {
            NewsLetterSignupEntity entity = model;
            _dataContext.Add(entity);
            await _dataContext.SaveChangesAsync();
            return true;
        }
        catch { return false; }
    }

}
