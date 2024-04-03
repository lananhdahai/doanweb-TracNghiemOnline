using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TracNghiemOnline.Models;

public  class Lophoc
{
    public int Id { get; set; }

    [Required]
    public string Tenlop { get; set; }

    public string? Mota { get; set; }

    public List<Dethi>? Dethis { get; set; }    


}
