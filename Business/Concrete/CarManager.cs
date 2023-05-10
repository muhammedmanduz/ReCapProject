using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        //veri Erişim 
        ICarDal _carDal;

        public CarManager(ICarDal carDal) //generate constructor olusturduk
        {
            _carDal = carDal;
        }

        public List<Car> GetAll()
        {
            //iş kodları 
            return _carDal.GetAll();
        }
    }
}
