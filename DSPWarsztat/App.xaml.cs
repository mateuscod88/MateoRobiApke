using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using DSPWarsztat.ViewModel;
using DSPWarsztat.Model;
using System.Collections.ObjectModel;
namespace DSPWarsztat
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            ObservableCollection<CarModel> carsy = new ObservableCollection<CarModel>();
            carsy.Add(new CarModel("Audi", "A4", "2004", "BIA8406"));
            carsy.Add(new CarModel("VW", "Passat", "2000", "BIA00568"));
            MainWindow mw = new MainWindow();
            AllCarsViewModel lvm = new AllCarsViewModel(carsy);
            mw.DataContext = lvm;
            mw.Show();
        }
    }
}
