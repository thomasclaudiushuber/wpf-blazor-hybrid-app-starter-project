using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System.Data;
using System.Windows;

namespace WpfBlazorHybridApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            var services= new ServiceCollection();
            ConfigureServices(services);
            var serviceProvider = services.BuildServiceProvider();
            this.Resources.Add("ServiceProvider", serviceProvider);
        }

        private void ConfigureServices(ServiceCollection services)
        {
            services.AddWpfBlazorWebView();

    #if DEBUG
            services.AddBlazorWebViewDeveloperTools();
    #endif
        }
    }

}
