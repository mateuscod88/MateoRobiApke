using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSPWarsztat.HelpClass;
using DSPWarsztat.Model;
namespace DSPWarsztat.ViewModel
{
    public class AddCarsViewModel : Notify
    {
        public SelectedCarModel NewCar { get; set; }
        public AddCarsViewModel() 
        {
            NewCar = new SelectedCarModel();
        }
    }
}
