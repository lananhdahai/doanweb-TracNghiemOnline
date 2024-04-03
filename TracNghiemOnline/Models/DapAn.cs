using System.ComponentModel.DataAnnotations;

namespace TracNghiemOnline.Models
{
    public class DapAn
    {

        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public List<Cauhoi> ? cauhois { get; set; }   
    }
}
