using System;
using System.Collections.Generic;

namespace TracNghiemOnline.Models;

public  class Taikhoan
{
    public int Id { get; set; }

    public int Idloaitk { get; set; }

    public string Tentaikhoan { get; set; } = null!;

    public string Matkhau { get; set; } = null!;

    public string? Hoten { get; set; }

    public string? Email { get; set; }

    public DateTime? Ngaysinh { get; set; }

    public long? Sdt { get; set; }


}
