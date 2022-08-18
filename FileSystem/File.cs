using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem
{
    internal class File
    {
        public string Name { get; set; }  
        public string Path { get; set; }
        public string Expansion { get; set; }
        public List<string> Access = new List<string>();
        public bool Check { get; set; }
        
    }
}
