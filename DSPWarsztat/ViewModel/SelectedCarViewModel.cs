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
    public class SelectedCarViewModel : ObservableCollection<NotesModel>
    {
        public SelectedCarModel currentCarModel { get; set; }
        public NotesModel Naprawa { get; set; }
        public ICollectionView Notes { get; private set; }

        public SelectedCarViewModel(ObservableCollection<NotesModel> naprawy)
        {
            currentCarModel = new SelectedCarModel("Audi", "A4", "2004", "BIA8406", "240404", "12.04.2016", "513524045", "1.9TDI");
            Notes = new ListCollectionView(naprawy);
            

        }

    }
}
