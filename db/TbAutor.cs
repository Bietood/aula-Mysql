using System;
using System.Collections.Generic;

namespace aula_Mysql.db;

public partial class TbAutor
{
    public int IdAutor { get; set; }

    public string? Nome { get; set; }

    public string? NrFone { get; set; }

    public string? Pais { get; set; }

    public virtual ICollection<TbLivro> TbLivros { get; set; } = new List<TbLivro>();
}
