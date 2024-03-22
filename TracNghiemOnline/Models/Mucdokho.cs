using System;
using System.Collections.Generic;

namespace TracNghiemOnline.Models;

public partial class Mucdokho
{
    public int Iddokho { get; set; }

    public string? Tendk { get; set; }

    public virtual ICollection<Cauhoi> Cauhois { get; set; } = new List<Cauhoi>();
}
