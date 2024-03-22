using System;
using System.Collections.Generic;

namespace TracNghiemOnline.Models;

public partial class Taikhoan
{
    public int Idtk { get; set; }

    public int Idloaitk { get; set; }

    public string Tentaikhoan { get; set; } = null!;

    public string Matkhau { get; set; } = null!;

    public string? Hoten { get; set; }

    public string? Email { get; set; }

    public DateTime? Ngaysinh { get; set; }

    public long? Sdt { get; set; }

    public virtual Loaitk IdloaitkNavigation { get; set; } = null!;

    public virtual ICollection<Ketqua> Ketquas { get; set; } = new List<Ketqua>();

    public virtual ICollection<Dethi> Iddethis { get; set; } = new List<Dethi>();
}
