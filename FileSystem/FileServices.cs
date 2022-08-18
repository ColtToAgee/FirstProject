using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleTables;

namespace FileSystem
{
    class FileServices
    {
        List<File> dosyalar=new List<File>();
        int secim=0;
        
        public void Create()
        {
            RecordForm record = new RecordForm();
            File dosya = new File();
            Console.WriteLine("Dosya İsmini Giriniz:");
            dosya.Name = Console.ReadLine();
            Console.WriteLine("Dosya Yolunu Giriniz:");
            dosya.Path = Console.ReadLine();
            Console.WriteLine("Dosya Uzantısını Giriniz:");
            dosya.Expansion = Console.ReadLine();
            Console.WriteLine("Dosyaya Erişecek Kişiyi Giriniz:");
            dosya.Access.Add(Console.ReadLine());
            dosya.Check = true;
            dosyalar.Add(dosya);
        }
        public void Delete()
        {
            Console.WriteLine("Silmek İstediğiniz Dosyayı Seçiniz:");
            Listele();
            if (!ShowCheckControl(dosyalar[secim]))
            {
                secim = Convert.ToInt32(Console.ReadLine());
                dosyalar.RemoveAt(secim);
            }
            else { ShowCheckControl(dosyalar[secim]); }
        }
        public void Upload()
        {
            Console.WriteLine("Yüklemek İstediğiniz Dosyayı Seçiniz");
            Create();
            Console.WriteLine("Dosya Yüklendi!!!");
        }
        public void ChangeName()
        {
            Console.WriteLine("Adını Değiştirmek İstediğiniz Dosyayı Seçiniz:");
            Listele();
            secim=Convert.ToInt32(Console.ReadLine());
            if (!ShowCheckControl(dosyalar[secim]))
            {
                Console.WriteLine("Dosya Adını Giriniz:");
                var name = Console.ReadLine();
                dosyalar[secim].Name = name;
            }
            else { ShowCheckControl(dosyalar[secim]); }
        }
        public void ChangePath()
        {
            Console.WriteLine("Dosya Yolunu Değiştirmek İstediğiniz Dosyayı Seçiniz:");
            Listele();
            secim = Convert.ToInt32(Console.ReadLine());
            if (!ShowCheckControl(dosyalar[secim]))
            {
                Console.WriteLine("Dosya Yolunu Giriniz:");
                var path = Console.ReadLine();
                dosyalar[secim].Path = path;
            }
            else { ShowCheckControl(dosyalar[secim]); }
        }
        public void ChangeExpansion()
        {
            Console.WriteLine("Dosya Uzantısını Değiştirmek İstediğiniz Dosyayı Seçiniz:");
            Listele();
            secim = Convert.ToInt32(Console.ReadLine());
            if (!ShowCheckControl(dosyalar[secim]))
            {
                Console.WriteLine("Dosya Uzantısını Giriniz:");
                var expansion = Console.ReadLine();
                dosyalar[secim].Expansion = expansion;
            }
            else { ShowCheckControl(dosyalar[secim]); }
        }
        public void AddAccess()
        {
            Console.WriteLine("Erişim Ekleyeceğiniz Dosyayı Seçiniz:");
            Listele();
            secim = Convert.ToInt32(Console.ReadLine());
            if (!ShowCheckControl(dosyalar[secim]))
            {
                Console.WriteLine("Dosyaya Erişecek Kişiyi Giriniz:");
                var kisi = Console.ReadLine();
                dosyalar[secim].Access.Add(kisi);
            }
            else { ShowCheckControl(dosyalar[secim]); }
        }
        public void DeleteAccess()
        {
            Console.WriteLine("Erişim Sileceğiniz Dosyayı Seçiniz:");
            Listele();
            secim = Convert.ToInt32(Console.ReadLine());
            if (!ShowCheckControl(dosyalar[secim]))
            {
                Console.WriteLine("Erişimi Silenecek Kişiyi Giriniz:");
                var kisi2 = Console.ReadLine();
                dosyalar[secim].Access.Remove(kisi2);
            }
            else { ShowCheckControl(dosyalar[secim]); }
        }
        public void ErisimleriListele()
        {
            Console.WriteLine("Erişimleri Listeleyeceğiniz Dosyayı Seçiniz:");
            Listele();
            secim= Convert.ToInt32(Console.ReadLine());
            var table=new ConsoleTable("Kişiler");
            foreach ( var items in dosyalar[secim].Access)
            {
                table.AddRow(items);
            }
            table.Write();
        }
        public bool ShowCheckControl(File file)
        {
            if (file.Check) 
            { 
                Console.WriteLine("Dosya Check-In Lütfen Bekleyiniz!!!"); 
                return true; 
            }
            else 
            { 
                Console.WriteLine("Dosya Check-Out!!!"); 
                return false; 
            }
        }
        public void Listele()
        {
            var table = new ConsoleTable("Number", "File Name", "File Path", "File Check");
            int i = 0;
            foreach (File f in dosyalar)
            {
                table.AddRow(i, $"{f.Name}.{f.Expansion}", f.Path, $"Check-In {f.Check}");
                i++;
            }
            table.Write();
        }
        public void CheckOut()
        {
            Console.WriteLine("Check-Out Yapılacak Dosyayı Seçiniz:");
            Listele();
            secim= Convert.ToInt32(Console.ReadLine());
            dosyalar[secim].Check = false;
        }
        public void CheckIn()
        {
            Console.WriteLine("Check-In Yapılacak Dosyayı Seçiniz:");
            Listele();
            secim = Convert.ToInt32(Console.ReadLine());
            dosyalar[secim].Check = true;
        }
        public File Send()
        {
            Console.WriteLine("Gönderilecek Dosyayı Seçiniz:");
            Listele();
            secim = Convert.ToInt32(Console.ReadLine());
            if (!ShowCheckControl(dosyalar[secim]))
            {
                return dosyalar[secim];
            }
            else 
            { 
                ShowCheckControl(dosyalar[secim]);
                return null;
            }
        }
    }
}
