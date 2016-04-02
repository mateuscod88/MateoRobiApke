using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using DSPWarsztat.Model;
using System.ComponentModel;
namespace DSPWarsztat.ViewModel
{
    public class SelectedCarViewModel : ObservableCollection<SelectedCarViewModel>
    {
        public SelectedCarModel currentCarModel { get; set; }
        public NotesModel Naprawa { get; set; }
        public ICollectionView Notes { get; private set; }

    }
}
