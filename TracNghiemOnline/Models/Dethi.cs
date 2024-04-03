using System;
using System.Collections.Generic;

namespace TracNghiemOnline.Models;

public  class Dethi
{
    public int Id { get; set; }

    public int Gio { get; set; }

    public int Phut { get; set; }

    public int SlCau { get; set; }

    public string ? ImageUrl { get; set; }    

    public DateTime  NgayTao { get; set; }

    public string Noidung { get; set; } 

    //public string Image { get; set; } 
    
    



    public int LophocId { get; set; }   
    public Lophoc ? Lophoc { get; set; }

    public int MonhocId { get; set; }
    public Monhoc? Monhoc { get; set; }







}
