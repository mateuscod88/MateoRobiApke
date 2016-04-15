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
        public RepairModel repairModel { get; set; }

    }
}
