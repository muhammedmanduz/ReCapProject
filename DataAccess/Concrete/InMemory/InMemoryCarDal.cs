using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        
        List<Car> _car; //global degisken


        public InMemoryCarDal() //Constructor: program çalıstıgı anda o newlendıgı anda burası calısır
        {
            _car = new List<Car>
            {
                  //Bellekte çalışacagız  sankı herhangı bır veritabanında veri cekiyoruz.
                 //sankı bellekte  data varmıs gıbı bız onu yonetiyor olacagız 
                new Car {CarId=1,BrandId=1,ColorId=1, ModelYear=2000,DailyPrice=100, Description="Honda"},
                new Car {CarId=2,BrandId=1,ColorId=1, ModelYear=2010,DailyPrice=100, Description="Hyundai"},
                new Car {CarId=3,BrandId=2,ColorId=2, ModelYear=2015,DailyPrice=100, Description="Toyota"},
                new Car {CarId=4,BrandId=3,ColorId=2, ModelYear=2016,DailyPrice=100, Description="Mazda"},
                new Car {CarId=5,BrandId=3,ColorId=3, ModelYear=2020,DailyPrice=100, Description="Renault"}
            };
        }
        public void Add(Car car)
        {
            //businesstan bana gonderılen urunu parametre olarak(car) alıp ekledım

            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carDelete = _car.SingleOrDefault(p=>p.CarId==car.CarId); 

            _car.Remove(carDelete);

            
        }

        public List<Car> GetAll()
        {
           
            //veritabanındakı datayı businesse utun listesını vermem lazım 
           //veritabanını oldugu gıbı dondurur
            return _car;
        }

        public List<Car> GetByCarId()
        {
            throw new NotImplementedException();
        }

        public List<Car> GetByCarId(int carId)
        {
          return  _car.Where(p=>p.CarId == carId).ToList();
        }

       

        public void Update(Car car)
        {
            //gönderdiğim  ürün id'sine sahip olan listedeki ürün idsini bul
            Car carToUpdate=_car.SingleOrDefault(P=>P.CarId==car.CarId);  
            carToUpdate.CarId=car.CarId;
            carToUpdate.BrandId=car.BrandId;
            carToUpdate.ColorId=car.ColorId;
            carToUpdate.DailyPrice=car.DailyPrice;
            carToUpdate.Description=car.Description;
            carToUpdate.ModelYear=car.ModelYear;
        }
    }
}
