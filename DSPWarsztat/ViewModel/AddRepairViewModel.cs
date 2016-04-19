using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSPWarsztat.Model;
namespace DSPWarsztat.ViewModel
{
    class AddRepairViewModel
    {
<<<<<<< HEAD
		private ICommand backToPreviousWin;
		private ICommand addRepair;
		public ICommand AddRepair
		{
			get
			{
				if(addRepair == null)
				{
					addRepair = new RelayCommand(param =>)
				}
			}
		}
=======
	private ICommand addRepairCmd;
	private ICommand backToPreviousViewCmd;
	public ICommand AddRepairCmd
	{
		get
		{
			if(addRepairCmd == null)
			{
			  addRepairCmd = new RelayCommand(param => addRepair(),param => canAddRepair());
			}
		  return addRepairCmd;
		}	
	}
	public ICommand BackToPreviousViewCmd
	{
		get
		{
			if(backToPreviousViewCmd == null)
			{
				backToPreviousViewCmd = new RelayCommand(param => backToPreviousView(),param => canBackToPreviousView());
			}
		  return backToPreviousView;
		}
	}
>>>>>>> b8b1be9b6926f4410177237520ba9769bdf0590e
        public RepairModel repairModel { get; set; }

    }
}
