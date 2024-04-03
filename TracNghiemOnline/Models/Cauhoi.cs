using System;
using System.Collections.Generic;

namespace TracNghiemOnline.Models;

public  class Cauhoi
{
    public int Id { get; set; }

    public string Noidung { get; set; } 

    public string? DaA { get; set; }

    public string? DaB { get; set; }

    public string? DaC { get; set; }

    public string? DaD { get; set; }

    public string? Khac { get; set; }



    public string? Da { get; set; }


    public string ? ImageUrl { get; set; }

 

    public int DethiId { get; set; }    
    public Dethi ? Dethi { get; set; }

   

    public int DapAnId { get; set; }
    public DapAn? DapAns { get; set; }


}
