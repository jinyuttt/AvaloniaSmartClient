using Avalonia.Markup.Xaml;
using AvaloniaUI.Ribbon;

namespace AvaloniaSmartClient.Views
{
    public class MainWindow : RibbonWindow
    {
        public MainWindow()
        {
            InitializeComponent();

           // App.Selector?.EnableThemes(this);
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
