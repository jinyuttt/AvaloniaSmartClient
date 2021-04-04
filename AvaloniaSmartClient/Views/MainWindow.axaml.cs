using Avalonia.Controls;
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
           var tb= this.Find<TabControl>("tbMain");
            TabItem item = new TabItem() {  Header="≤‚ ‘"};
            item.Content = new FrmTask();
            TabItem tabItem = new TabItem() { Header = "≤‚ ‘»•" };
            tabItem.Content = new DataTask();
            tb.Items = new TabItem[] { item , tabItem };
        }
    }
}
