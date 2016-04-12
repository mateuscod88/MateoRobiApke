using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSPWarsztat.HelpClass;
using DSPWarsztat.Model;
using System.Windows.Input;
namespace DSPWarsztat.ViewModel
{
    public class AddCarsViewModel : Notify
    {
        public SelectedCarModel NewCar { get; set; }
        private ICommand saveCar;
        private ICommand backToPreviousView;
        
        public AddCarsViewModel() 
        {
            NewCar = new SelectedCarModel();
        }

        public ICommand SaveCar
        {
            get
            {
                if(saveCar == null)
                {
                    saveCar = new RelayCommand(param => save(),param => canSave());
                }
            return saveCar;
            }
        }
        private void save()
        {
            Car currentCar = new Car(NewCar.Brand,NewCar.Model,NewCar.Year,NewCar.RegNumber,NewCar.Mileage,NewCar.DateVechicleCheckUp,NewCar.PhoneNumber,NewCar.Engine);
            DemoDatabase.AddCarToDb(NewCar.RegNumber, currentCar);
        }
        
        private bool canSave()
        {
            return NewCar.Model != "";
        }
    }
}
