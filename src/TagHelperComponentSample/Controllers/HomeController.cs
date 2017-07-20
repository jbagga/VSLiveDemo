using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor.TagHelpers;

namespace TagHelperComponentSample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITagHelperComponentManager _tagHelperComponentManager;

        public HomeController(ITagHelperComponentManager tagHelperComponentManager)
        {
            _tagHelperComponentManager = tagHelperComponentManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddComponent()
        {
            _tagHelperComponentManager.Components.Add(new MyTagHelperComponent(0, "<p>TagHelperComponent added from controller.</p>"));
            return View("AddComponent");
        }
    }
}
