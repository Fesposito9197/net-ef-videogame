using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_ef_videogame
{
    [Table("softwareHouse")]
    public class SoftwareHouse
    {
        public int Id {get;set;}
        public string name { get;set;}
        public string city { get;set;}
        public string country { get;set;}

       public List<Videogame> videogames { get;set;}
    }
}
