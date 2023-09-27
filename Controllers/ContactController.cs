using Crito.Models;
using Crito.Services;
using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Core.Logging;
using Umbraco.Cms.Core.Routing;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Infrastructure.Persistence;
using Umbraco.Cms.Web.Website.Controllers;

namespace Crito.Controllers;

public class ContactController : SurfaceController
{
    private readonly ContactService _contactService;
    public ContactController(IUmbracoContextAccessor umbracoContextAccessor, IUmbracoDatabaseFactory databaseFactory, ServiceContext services, AppCaches appCaches, IProfilingLogger profilingLogger, IPublishedUrlProvider publishedUrlProvider, ContactService contactService) : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
    {
        _contactService = contactService;
    }


    [HttpPost]
    public async Task<IActionResult> Index(ContactModel contactModel)
    {
        if (!ModelState.IsValid)
            return CurrentUmbracoPage();
        
        await _contactService.CreateAsync(contactModel);

        return LocalRedirect("/");
    }
}
