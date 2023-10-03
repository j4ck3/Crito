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

public class HomeController : SurfaceController
{
    private readonly NewsSignupService _newsSignupService;
    public HomeController(IUmbracoContextAccessor umbracoContextAccessor, IUmbracoDatabaseFactory databaseFactory, ServiceContext services, AppCaches appCaches, IProfilingLogger profilingLogger, IPublishedUrlProvider publishedUrlProvider, NewsSignupService newsSignupService) : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
    {
        _newsSignupService = newsSignupService;
    }

    [HttpPost]
    public async Task<IActionResult> Index(NewsLetterSignupModel signupModel)
    {
        if (!ModelState.IsValid)
            return CurrentUmbracoPage();

        if(await _newsSignupService.CreateAsync(signupModel))
            TempData["SignupSuccess"] = "You are now signed up on our newsletter!";

        return CurrentUmbracoPage();
    }
}
