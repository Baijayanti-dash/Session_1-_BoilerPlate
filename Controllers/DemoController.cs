using Microsoft.AspNetCore.Mvc;
using Session_1__BoilerPlate.Interface;

namespace Session_1__BoilerPlate.Controllers
{
    public class DemoController : Controller
    {
        private readonly IDemoInterface _demoInterface;
        private readonly IServiceProvider _serviceProvider;
        public DemoController(IDemoInterface myInterface, IServiceProvider serviceProvider)
        {
            _demoInterface = myInterface;
            _serviceProvider = serviceProvider;
        }
        public IActionResult Index()
        {
            try
            {

                string value = _demoInterface.GetMyValue();

                ViewData["MyValue"] = value;

                return View();

            }
            catch (Exception ex)
            {
                var errorController = _serviceProvider.GetRequiredService<ErrorController>();
                return errorController.MyException();
            }
        }
    }
}
