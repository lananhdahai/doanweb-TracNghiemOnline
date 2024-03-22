using System;
using System.Collections.Generic;

namespace TracNghiemOnline.Models;

public partial class Dethi
{
    public int Iddethi { get; set; }

    public int? Thoigianthi { get; set; }

    public int? Slcau { get; set; }

    public DateTime? Ngaythi { get; set; }

    public virtual ICollection<Ketqua> Ketquas { get; set; } = new List<Ketqua>();

    public virtual ICollection<Cauhoi> Idcauhois { get; set; } = new List<Cauhoi>();

    public virtual ICollection<Taikhoan> Idtks { get; set; } = new List<Taikhoan>();
}
