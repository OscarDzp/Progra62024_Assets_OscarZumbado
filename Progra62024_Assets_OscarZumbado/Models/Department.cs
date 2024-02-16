using System;
using System.Collections.Generic;

namespace Progra62024_Assets_OscarZumbado.Models;

public partial class Department
{
    public int DepartmentId { get; set; }

    public string DepartmentName { get; set; } = null!;

    public virtual ICollection<Asset> Assets { get; set; } = new List<Asset>();
}
