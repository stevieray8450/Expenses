using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace TestAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //var builder = new ContainerBuilder();

            //// register types here for DI
            //builder.RegisterType<AccountsDataAccess>().As<IBaseDa<Accounts>>();

            //_container = builder.Build();

            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
