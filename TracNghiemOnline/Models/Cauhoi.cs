using System;
using System.Collections.Generic;

namespace TracNghiemOnline.Models;

public partial class Cauhoi
{
    public long Idcauhoi { get; set; }

    public string Noidung { get; set; } = null!;

    public string? DaA { get; set; }

    public string? DaB { get; set; }

    public string? DaC { get; set; }

    public string? DaD { get; set; }

    public string? Loigiai { get; set; }

    public int? Idmon { get; set; }

    public string? Da { get; set; }

    public int? Iddokho { get; set; }

    public byte[]? Imgch { get; set; }

    public byte[]? Videoch { get; set; }

    public virtual Mucdokho? IddokhoNavigation { get; set; }

    public virtual Monhoc? IdmonNavigation { get; set; }

    public virtual ICollection<Ketqua> Ketquas { get; set; } = new List<Ketqua>();

    public virtual ICollection<Dethi> Iddethis { get; set; } = new List<Dethi>();
}
