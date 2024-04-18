using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

public partial class SinhVien
{
    public int Id { get; set; }

    public string TenSinhVien { get; set; } = null!;

    public int LopId { get; set; }

    public int Age { get; set; }

    public virtual Lop Lop { get; set; } = null!;
}
