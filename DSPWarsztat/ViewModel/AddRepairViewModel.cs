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
	private void addRepair()
	{
		
	}
	private bool canAddRepair()
	{
		
	}
    	private void backToPreviousView()
	{
		
	}
	private bool canBackToPreviousView()
	{
		
	}
	public RepairModel repairModel { get; set; }

    }
}
