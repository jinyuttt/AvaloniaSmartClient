using Avalonia;
using Avalonia.Collections;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using System.Collections.Generic;
using System.Linq;

namespace AvaloniaSmartClient.Views
{
    public class DataTask : UserControl
    {
        static IEnumerable<Country> GetCountries()
        {
            yield return new Country("Afghanistan", "ASIA (EX. NEAR EAST)", 31056997, 647500, 48, 0, 23.06, 163.07, 700, 36, 3.2, 46.6, 20.34);
            yield return new Country("Albania", "EASTERN EUROPE", 3581655, 28748, 124, 1, -4.93, 21.52, 4500, 86, 71.2, 15.11, 5.22);
            yield return new Country("Algeria", "NORTHERN AFRICA", 32930091, 2381740, 13,4, -0.39, 31, 6000, 70, 78.1, 17.14, 4.61);
            yield return new Country("American Samoa", "OCEANIA", 57794, 199, 290, 58, -20.71, 9.27, 8000, 97, 259.5, 22.46, 3.27);
            yield return new Country("Andorra", "WESTERN EUROPE", 71201, 468, 152, 0, 6.6, 4.05, 19000, 100, 497.2, 8.71, 6.25);
        }
        public DataTask()
        {
            InitializeComponent();
            var dg1 = this.FindControl<DataGrid>("dataGrid1");
            dg1.IsReadOnly = true;

            var collectionView1 = new DataGridCollectionView(GetCountries().ToList().AsReadOnly());
            dg1.Items = collectionView1;
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
