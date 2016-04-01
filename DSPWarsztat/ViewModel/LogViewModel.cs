using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSPWarsztat.HelpClass;
using DSPWarsztat.Model;
namespace DSPWarsztat.ViewModel
{
    class LogViewModel : Notify
    {
        private LogModel _model = new LogModel();
        public LogModel Modell
        {
            get { return _model; }
            set
            {
                if (_model != value)
                    _model = value;
                OnPropertyChanged("Modell");
            }
        }
       
    }
}
