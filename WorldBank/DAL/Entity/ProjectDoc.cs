using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class ProjectDoc
    {
        public string DocTypeDesc { get; set; }
        public string DocType { get; set; }
        public string EntityID { get; set; }
        public Uri DocURL { get; set; }
        public DateTime DocDate { get; set; } 
    }
}
