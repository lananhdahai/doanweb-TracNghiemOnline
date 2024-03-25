using System;
using System.Collections.Generic;

namespace TracNghiemOnline.Models;

public partial class Monhoc
{
    public int Idmon { get; set; }

    public string? Tenmon { get; set; }

    public string? Mota { get; set; }

    public int Idlop { get; set; }

    public virtual ICollection<Cauhoi> Cauhois { get; set; } = new List<Cauhoi>();

    public virtual Lophoc IdlopNavigation { get; set; } = null!;
}
