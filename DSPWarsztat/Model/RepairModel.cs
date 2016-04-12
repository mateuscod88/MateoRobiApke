using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSPWarsztat.HelpClass;
namespace DSPWarsztat.Model
{
    class RepairModel : Notify
    {
        private string _name;
        private string _date;
        private string _mileagee;

        public RepairModel()
        {
            _name = "Rozrzad";
            _date = "wtorek";
            _mileagee = "120000";
        }
        public string Name
        {
            get { return _name; }
            set
            {
                if(_name != null)
                {
                    _name = null;
                    OnPropertyChanged();
                }
            }
        }
        public string Date
        {
            get { return _date; }
            set
            {
                if (_date != null)
                {
                    _date = null;
                    OnPropertyChanged();
                }
            }
        }
        public string Mileage
        {
            get { return _mileagee; }
            set
            {
                if (_mileagee != null)
                {
                    _mileagee = null;
                    OnPropertyChanged();
                }
            }
        }
    }
}
