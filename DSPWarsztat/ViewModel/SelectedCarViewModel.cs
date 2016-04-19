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
        private ICommand addRepair;
	public SelectedCarModel currentCarModel { get; set; }
        public NotesModel Naprawa { get; set; }
	public CollectionView Notes { get; private set; }   
        

	 public ICommand AddRepair
	{
		get
		{
		 if(addRepair == null)
		 {
			addRepair = new RelayCommand(param => addingRepair(), param => canAddRepair());
		 }
		 return addRepair;
		}
	}
	private void addingRepair()
	{
		
	}
	private bool canAddRepair()
	{
		
	}
        public SelectedCarViewModel(ObservableCollection<NotesModel> naprawy)       
        {
            currentCarModel = new SelectedCarModel("Audi", "A4", "2004", "BIA8406", "240404", "12.04.2016", "513524045", "1.9TDI");
            Notes = new ListCollectionView(naprawy);
            

        }

    }
}
