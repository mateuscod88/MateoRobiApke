using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPWarsztat.HelpClass
{
    static class DemoDatabase
    {
        static private Dictionary<string, Car> cars = new Dictionary<string,Car>();
        static public void AddCarToDb(string carNumReg, Car addedCar)
        {
            cars.Add(carNumReg, addedCar);
        }
    }
}
