using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using DSPWarsztat.HelpClass;
namespace DSPWarsztat.Model
{
    public class CarModel : Notify
    {
        //Property
        #region 
        private string _brand;
        private string _model;
        private string _year;
        private string _regNumber;
        
        public string Brand
        {
            get { return _brand; }
            set 
            {
                if(_brand != value)
                {
                    _brand = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Model
        {
            get { return _model; }
            set
            {
                if (_model != value)
                {
                    _model = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Year
        {
            get { return _year; }
            set
            {
                if (_year != value)
                {
                    _year = value;
                    OnPropertyChanged();
                }
            }
        }
        public string RegNumber
        {
            get { return _regNumber; }
            set
            {
                if (_regNumber != value)
                {
                    _regNumber = value;
                    OnPropertyChanged();
                }
            }
        }

    
        #endregion
        //Construktor
        public CarModel()
        {

        }   
        public CarModel(string brand , string model , string year, string regNumber)        
        {
            _brand = brand;
            _model = model;
            _year = year;
            _regNumber = regNumber;
        }
    }
}
