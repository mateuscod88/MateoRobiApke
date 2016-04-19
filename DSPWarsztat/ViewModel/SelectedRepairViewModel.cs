using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSPWarsztat.HelpClass;
using DSPWarsztat.Model;
namespace DSPWarsztat.ViewModel
{
    class SelectedRepairViewModel : Notify
    {
        private RepairModel _repair;
        private ICommand editRepairCmd;
	private ICommand backToPreviousViewCmd;
	public ICommand EditRepairCmd
	{
		get
		{
			if(editRepairCmd == null)
			{
				editRepairCmd = new RelayCommand(param => editRepair(),param => canEdit());
			}
			return editRepairCmd;
		}
	}
	public ICommand BackToPreviousViewCmd
	{
		get
		{
			if(backToPreviousViewCmd == null)
			{
					backToPreviousViewCmd = new RelayCommand(param => back(),param => canBack());
			}
			 return backToPreviousViewCmd;
		}
	}
	public string RepName{get;set;}
        
	public RepairModel Repair
        { 
            get { return _repair; }
            set {
                if (_repair != value)
                    _repair = value;
                OnPropertyChanged();
            }
        }
        public SelectedRepairViewModel(){
            Repair = new RepairModel();
            RepName = "Rozrzad";
        }
		
	private void editRepair()
	{
			
	}
	private bool canEdit()
	{
			
	}
        private void back()
	{
			
	}
	private bool canBack()
	{
			
	}
    }
}
