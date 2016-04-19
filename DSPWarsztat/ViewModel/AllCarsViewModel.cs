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
        
	private ICommand addNewCarCmd;
	private ICommand deleteCarCmd;
	private ICommand showCarCmd;
	public ICommand AddNewCarCmd
	{
		get
		{
			if(addNewCarCmd == null)
			{
			   addNewCarCmd = new RelayCommand(param => addNewCar(),			   canAddNewCar());
			}
		 return addNewCarCmd;
		}
	}
	public ICommand DeleteNewCarCmd
	{
		get
		{
			if(deleteCarCmd == null)
			{
			  deleteCarCmd = new RelayCommand(param => deleteCar(),
			  param => canDeleteCar());
			}
		  return deleteCarCmd;
		}
	}
	public ICommand ShowCarCmd
	{
		get
		{
			if(showCarCmd == null)
			{
			 showCarCmd = new RelayCommand(param => showCar(),
			 param => canShowCar());
			}
		  return showCarCmd;
		}
	}
	public ICollectionView Customers { get; private set; }
        
        public AllCarsViewModel(ObservableCollection<CarModel> cars)
        {
            Customers = new ListCollectionView(cars);
        }
    }
}
