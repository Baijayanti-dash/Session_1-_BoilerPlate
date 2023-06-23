using Session_1__BoilerPlate.Interface;

namespace Session_1__BoilerPlate.Services
{
    public class DemoService : IDemoInterface
    {
        private readonly IConfiguration _configuration;
        private readonly IWebHostEnvironment _environment;

        public DemoService(IConfiguration configuration, IWebHostEnvironment environment)
        {
            _configuration = configuration;
            _environment = environment;
        }
        public string GetMyValue()
        {
            string name = _configuration.GetValue<string>("MyData:Name");

            return name;
        }
    }
}
