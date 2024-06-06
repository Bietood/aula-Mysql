using System;
using System.Collections.Generic;

namespace aula_Mysql.db;

public partial class TbCategorium
{
    public int IdCategoria { get; set; }

    public string? NmCategoria { get; set; }

    public string? DsCategoria { get; set; }

    public virtual ICollection<TbLivro> TbLivros { get; set; } = new List<TbLivro>();
}
