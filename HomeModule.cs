using Nancy;
namespace NancyApplication
{
        public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get("/", args => "Hello World, it's Nancy on .NET Core");
            Get("/test/{name}", args => new Person() { Name = args.name });
        }
    }
}