using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleTables;
using System.Threading;

namespace FileSystem
{
    internal class FileMenu
    {
        public File Menu()
        {
            FileServices fileServices = new FileServices();
            File file = null; 
            while (true)
            {
                var table = new ConsoleTable("Dosya Menüsüne Hoşgeldiniz!!!");
                table.AddRow("Dosya Oluştur")
                    .AddRow("Dosya Sil ")
                    .AddRow("Ad Değiştir")
                    .AddRow("Yol Değiştir")
                    .AddRow("Uzantı Değiştir")
                    .AddRow("Erişim Ekle")
                    .AddRow("Erişim Sil")
                    .AddRow("Erişim Listele")
                    .AddRow("Dosyaları Listele")
                    .AddRow("Dosya Yükle")
                    .AddRow("Dosya Gönder")
                    .AddRow("Check-In Yap")
                    .AddRow("Check-Out Yap")
                    .AddRow("Çık");
                table.Write();
                Console.WriteLine("Seçiminiz:");
                var secim = Console.ReadLine();
                if (secim == "Çık") { break; }
                int secim2 = 0;
                switch (secim)
                {
                    case "Dosya Oluştur":
                        fileServices.Create();
                        Console.WriteLine("Dosya Oluşturuldu!!!");
                        Thread.Sleep(2000);
                        break;
                    case "Dosya Sil":
                        fileServices.Delete();
                        Thread.Sleep(2000);
                        break;
                    case "Ad Değiştir":
                        fileServices.ChangeName();
                        Thread.Sleep(2000);
                        break;
                    case "Yol Değiştir":
                        fileServices.ChangePath();
                        Thread.Sleep(2000);
                        break;
                    case "Uzantı Değiştir":
                        fileServices.ChangeExpansion();
                        Thread.Sleep(2000);
                        break;
                    case "Erişim Ekle":
                        fileServices.AddAccess();
                        Thread.Sleep(2000);
                        break;
                    case "Erişim Sil":
                        fileServices.DeleteAccess();
                        Thread.Sleep(2000);
                        break;
                    case "Erişim Listele":
                        fileServices.ErisimleriListele();
                        Thread.Sleep(2000);
                        break;
                    case "Dosyaları Listele":
                        fileServices.Listele();
                        Thread.Sleep(2000);
                        break;
                    case "Dosya Yükle":
                        fileServices.Upload();
                        Thread.Sleep(2000);
                        break;
                    case "Dosya Gönder":
                        file = fileServices.Send();
                        Thread.Sleep(2000);
                        break;
                    case "Check-In Yap":
                        fileServices.CheckIn();
                        break;
                    case "Check-Out Yap":
                        fileServices.CheckOut();
                        break;
                }
            }
            return file;
        }
    }
}
