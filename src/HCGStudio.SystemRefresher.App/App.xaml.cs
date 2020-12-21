using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using HCGStudio.SystemRefresher.App.ViewModels;
using HCGStudio.SystemRefresher.App.Views;

namespace HCGStudio.SystemRefresher.App
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
                desktop.MainWindow = new MainWindow
                {
                    DataContext = new MainWindowViewModel()
                };

            base.OnFrameworkInitializationCompleted();
        }
    }
}