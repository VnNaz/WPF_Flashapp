using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using WPF_Flashapp.Views.Windows;

namespace WPF_Flashapp
{
    public partial class App : Application
    {
        private ServiceCollection _service = new ServiceCollection();
        private ServiceProvider _provider;
        public App()
        {
            _service.AddSingleton<MainWindow>();
            _provider = _service.BuildServiceProvider();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            var main = _provider.GetRequiredService<MainWindow>();
            main.Show();
            base.OnStartup(e);
        }
    }

}
