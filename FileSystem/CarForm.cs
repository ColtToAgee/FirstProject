using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleTables;

namespace FileSystem
{
    class CarForm
    {
        public void Form()
        {
            Car car = new Car();
            FileMenu fileMenu = new FileMenu();
            Console.WriteLine("Arabanın Markasını Yazınız:");
            car.Brand=Console.ReadLine();
            Console.WriteLine("Arabanın Modelini Yazınız:");
            car.Model=Console.ReadLine();
            Console.WriteLine("Arabanın Yılını Yazınız:");
            car.Year=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Arabanın Rengini Yazınız:");
            car.Color = Console.ReadLine();
            Console.WriteLine("Arabanın Yakıt Tipini Yazınız");
            car.FuelType=Console.ReadLine();
            Console.WriteLine("Arabanın Beygirini Yazınız:");
            car.HorsePower=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Arabanın Motor Hacmini Yazınız:");
            car.EngineCapacity=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Dosya Eklemek İçin Dosya Yazınız.");
            if (Console.ReadLine() == "Dosya")
            {
                car.Dosya=fileMenu.Menu();   
            }
            else
            {
                car.Dosya = null;
            }
            RecordServices recordServices = new RecordServices();
            recordServices.KayıtEkle(car.Brand,car.Dosya);
            var table2 = new ConsoleTable("Araba Bilgileri","");
            table2.AddRow("Marka:", car.Brand)
                .AddRow("Model:", car.Model)
                .AddRow("Yıl:", car.Year)
                .AddRow("Renk:", car.Color)
                .AddRow("Yakıt Tipi", car.FuelType)
                .AddRow("Beygir Gücü:", car.HorsePower)
                .AddRow("Motor Hacmi:", car.EngineCapacity)
                .AddRow("Dosya", car.Dosya.Name+"."+car.Dosya.Expansion);
            table2.Write();
        }
    }
}
