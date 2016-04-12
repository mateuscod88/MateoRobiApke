using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSPWarsztat.HelpClass;
namespace DSPWarsztat.Model
{
    public class SelectedCarModel : Notify
    {
        private string _brand;
        private string _model;
        private string _year;
        private string _regNumber;
        private string _mileage;
        private string _dateVechicleCheckUp;
        private string _phoneNumber;
        private string _engine;

        public SelectedCarModel()
        {
            _brand ="";
            _model = "";
            _year = "";
            _regNumber = "";
            _mileage = "";
            _dateVechicleCheckUp = "";
            _phoneNumber = "";
            _engine = "";
        }
        public SelectedCarModel(string brand,string model,string year,string regnum,string mileage,string dataVChecUp,string phoneNum,string engine)
        {
            _brand = brand;
            _model = model;
            _year = year;
            _regNumber = regnum;
            _mileage = mileage;
            _dateVechicleCheckUp = dataVChecUp;
            _phoneNumber = phoneNum;
            _engine = engine;
        }
        public string Brand
        {
            get { return _brand; }
            set
            {
                if (_brand != value)
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
        public string Engine
        {
            get { return _engine; }
            set
            {
                if (_engine != value)
                {
                    _engine= value;
                    OnPropertyChanged();
                }
            }
        }
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                if (_phoneNumber != value)
                {
                    _phoneNumber = value;
                    OnPropertyChanged();
                }
            }
        }
        public string DateVechicleCheckUp
        {
            get { return _dateVechicleCheckUp; }
            set
            {
                if (_dateVechicleCheckUp != value)
                {
                    _dateVechicleCheckUp = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Mileage
        {
            get { return _mileage; }
            set
            {
                if (_mileage != value)
                {
                    _mileage = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
