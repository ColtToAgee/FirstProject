using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem
{
    class RecordServices
    {
        RecordForm form=new RecordForm();
        public void KayıtEkle(string name,File file)
        {
            form.RecordName = name;
            form.RecordFile = file;
            Lists.Kayıt.Add(form);
        }
        public void KayıtSil(int id)
        {
            Lists.Kayıt.RemoveAt(id);
        }
        public void KayıtListele()
        {
            foreach(var items in Lists.Kayıt)
            {
                Console.WriteLine(items.RecordId+" - "+items.RecordName+" - "+items.RecordFile.Name+"."+items.RecordFile.Expansion);
            }
        }
    }
}
