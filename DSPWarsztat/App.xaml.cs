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
            //ObservableCollection<CarModel> carsy = new ObservableCollection<CarModel>();
            //carsy.Add(new CarModel("Audi", "A4", "2004", "BIA8406"));
            //carsy.Add(new CarModel("VW", "Passat", "2000", "BIA00568"));
            MainWindow mw = new MainWindow();
            //ObservableCollection<NotesModel> napraw = new ObservableCollection<NotesModel>();
            //napraw.Add(new NotesModel("Rozrzad", "2.03.2016"));
            //napraw.Add(new NotesModel("Wymiana Filtrow", "2.03.2015"));
            //napraw.Add(new NotesModel("Wymiana Wahacza","2.04.2015"));
            AddCarsViewModel  lvm = new AddCarsViewModel();
            mw.DataContext = lvm;
            mw.Show();
        }
    }
}
