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
        
    }
}
