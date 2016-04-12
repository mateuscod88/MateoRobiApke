using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPWarsztat.HelpClass
{
    class Car
    {
        private string _brand;
        private string _model;
        private string _year;
        private string _regNumber;
        private string _mileage;
        private string _dateVechicleCheckUp;
        private string _phoneNumber;
        private string _engine;
        
        public Car(string brand,string model,string year,string regnum,string mileage,string dataVChecUp,string phoneNum,string engine)
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
    }
}
