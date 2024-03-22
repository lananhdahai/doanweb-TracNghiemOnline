using System;
using System.Collections.Generic;

namespace TracNghiemOnline.Models;

public partial class Lophoc
{
    public int Idlop { get; set; }

    public string? Mota { get; set; }

    public string? Tenlop { get; set; }

    public virtual ICollection<Monhoc> Monhocs { get; set; } = new List<Monhoc>();
}
