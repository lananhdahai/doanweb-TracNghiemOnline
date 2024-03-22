using System;
using System.Collections.Generic;

namespace TracNghiemOnline.Models;

public partial class Ketqua
{
    public int Idtk { get; set; }

    public int Iddethi { get; set; }

    public long Idcauhoi { get; set; }

    public string? Da { get; set; }

    public virtual Cauhoi IdcauhoiNavigation { get; set; } = null!;

    public virtual Dethi IddethiNavigation { get; set; } = null!;

    public virtual Taikhoan IdtkNavigation { get; set; } = null!;
}
