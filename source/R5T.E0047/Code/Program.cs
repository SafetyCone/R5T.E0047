using System;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.Extensions.Hosting;

using R5T.D0088;
using R5T.D0090;


namespace R5T.E0047
{
    class Program : ProgramAsAServiceBase
    {
        #region Static
        
        static async Task Main()
        {
            //OverridableProcessStartTimeProvider.Override("20211214 - 163052");
            //OverridableProcessStartTimeProvider.DoNotOverride();
        
            await Instances.Host.NewBuilder()
                .UseProgramAsAService<Program, T0075.IHostBuilder>()
                .UseHostStartup<HostStartup, T0075.IHostBuilder>(Instances.ServiceAction.AddHostStartupAction())
                .Build()
                .SerializeConfigurationAudit()
                .SerializeServiceCollectionAudit()
                .RunAsync();
        }

        #endregion

        
        public Program(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {
        }

        protected override Task ServiceMain(CancellationToken stoppingToken)
        {
            return this.RunMethod();
            //return this.RunOperation();
        }

#pragma warning disable CA1822 // Mark members as static
#pragma warning disable IDE0051 // Remove unused private members

        private Task RunOperation()
        {
            return Task.CompletedTask;
        }

        private async Task RunMethod()
        {
            await this.GetIdentityName();
        }

        private Task GetIdentityName()
        {
            var output = Instances.ReflectedInstanceContextProvider.InExampleClass00Context(exampleClass00 =>
            {
                var output = Instances.IdentityNameProvider.GetIdentityName(exampleClass00);
                return output;
            });

            Console.WriteLine(output);

            return Task.CompletedTask;
        }
    }
}