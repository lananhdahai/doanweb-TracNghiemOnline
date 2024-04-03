using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TracNghiemOnline.Models;

public  class Monhoc
{
    public int Id { get; set; }
    [Required]
    public string Tenmon { get; set; }

    public List<Dethi>? Dethis { get; set; }
}
