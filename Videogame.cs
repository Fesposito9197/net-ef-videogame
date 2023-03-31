using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_ef_videogame
{
    [Table("videogame")]
    public class Videogame
    {
        public int Id {  get; set; }
        public string name { get; set; }
        public string overview { get; set; }

        public int SoftwareHouseId { get; set; }
        public SoftwareHouse SoftwareHouse { get; set; }
    }
}
