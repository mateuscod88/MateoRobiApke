using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using DSPWarsztat.Model;
using System.ComponentModel;
using System.Windows.Data;
namespace DSPWarsztat.ViewModel
{
    class AllCarsViewModel : ObservableCollection<CarModel>
    {
        public ICollectionView Customers { get; private set; }
        public AllCarsViewModel(ObservableCollection<CarModel> cars)
        {
            Customers = new ListCollectionView(cars);
        }
    }
}
