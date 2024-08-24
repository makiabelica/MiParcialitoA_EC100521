using System;
using System.Collections.Generic;

namespace MiParcialitoA.ModelsEC100521;

public partial class Municipio
{
    public int MunidepaId { get; set; }

    public string MuniId { get; set; } = null!;

    public string MuniNombre { get; set; } = null!;

    public string DepaId { get; set; } = null!;
}
