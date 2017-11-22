using System.Web.Mvc;
using Autofac.Features.Indexed;
using Calabonga.ConfigurationDemo.Infrastructure;

namespace Calabonga.ConfigurationDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationSettings _settingsProd;
        private readonly ApplicationSettings _settingsLocal;

        public HomeController(IIndex<string, ISettingsManager> configurations)
        {
            _settingsProd = configurations["PRODUCTION"].Config;
            _settingsLocal = configurations["LOCAL"].Config;
        }
        public ActionResult Index()
        {
            var emailServer = _settingsProd.EmailServer;
            var secretKey = _settingsLocal.SecretKey;

            return View();
        }

        /* cutted for briefly  */
    }
}