
using Business.Concrete;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI;

internal class Program
{
    static void Main(string[] args)
    {
        
        CarManager carManager =new CarManager(new InMemoryCarDal()); //hangı veri yönetimiyle calısır soyle
        foreach (var car in carManager.GetAll())
        {
            Console.WriteLine(car.Description);
        }


    }
}