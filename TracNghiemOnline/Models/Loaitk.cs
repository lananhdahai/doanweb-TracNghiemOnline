using System;
using System.Collections.Generic;

namespace TracNghiemOnline.Models;

public partial class Loaitk
{
    public int Idloaitk { get; set; }

    public string Loaitk1 { get; set; } = null!;

    public virtual ICollection<Taikhoan> Taikhoans { get; set; } = new List<Taikhoan>();
}
