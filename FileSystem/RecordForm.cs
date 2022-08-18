using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem
{
    class RecordForm
    {
        public int RecordId = 0; 
        public string RecordName { get; set; }
        public File RecordFile { get; set; }              
    }
}
