using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {

        // Referansı bagla
        // inMemory formatta buraya bagladık
        List<Car> GetAll();
        List<Car> GetByCarId();

        void Add(Car car);//parametre olarak Car alsın
        void Update(Car car); 
        void Delete(Car car);

        List<Car> GetByCarId(int carId);

    }
}
 