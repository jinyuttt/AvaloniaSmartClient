using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using Avalonia.ThemeManager;
using AvaloniaSmartClient.ViewModels;
using AvaloniaSmartClient.Views;
using System;

namespace AvaloniaSmartClient
{
    public class App : Application
    {
        public static ThemeSelector? Selector { get; set; }

       
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

       

        public override void OnFrameworkInitializationCompleted()
        {
            var mainWindowViewModel = new MainWindowViewModel();


            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktopLifetime)
            {
                Selector = ThemeSelector.Create("Themes");
                Selector.LoadSelectedTheme("AvaloniaApp.theme");
                desktopLifetime.MainWindow = new MainWindow()
                {
                    DataContext = mainWindowViewModel
                };
                desktopLifetime.Exit += (sennder, e) => Selector.SaveSelectedTheme("AvaloniaApp.theme");
            }
            base.OnFrameworkInitializationCompleted();
        }
    }
}
