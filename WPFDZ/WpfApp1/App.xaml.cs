using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System.Data;
using System.Windows;
using WpfApp1.Core;
using WpfApp1.Service;
using WpfApp1.Service.Interfaces;
using WpfApp1.ViewModel;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly ServiceProvider _serviceProvider;
        public App()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddSingleton<AboutViewModel>();
            services.AddSingleton<HomeViewModel>();
            services.AddSingleton<SettingsViewModel>();  // Register SettingsViewModel
            services.AddSingleton<MainViewModel>();
            services.AddSingleton<INavigateService, NavigateService>();
            services.AddSingleton(services => new MainWindow { DataContext = services.GetService<MainViewModel>() });
            services.AddSingleton<Func<Type, BaseViewModel>>(_serviceProvider => viewModelType => (BaseViewModel)_serviceProvider.GetRequiredService(viewModelType));
            _serviceProvider = services.BuildServiceProvider();
            /*
            IServiceCollection services = new ServiceCollection();
            services.AddSingleton<AboutViewModel>();
            services.AddSingleton<HomeViewModel>();
            services.AddSingleton<MainViewModel>();
            services.AddSingleton<INavigateService,INavigateService>();
            services.AddSingleton(services => new MainWindow {DataContext=services.GetService<MainViewModel>() });
            services.AddSingleton<Func<Type, BaseViewModel>>(_serviceProvider => viewModelType=>(BaseViewModel)_serviceProvider.GetRequiredService(viewModelType));
            _serviceProvider = services.BuildServiceProvider();
            */
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            var mainWindow=_serviceProvider.GetRequiredService<MainWindow>();
            mainWindow.Show();
            base.OnStartup(e);
        }
    }

}
