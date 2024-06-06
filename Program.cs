using aula_Mysql.db;

using System.Linq;

// using (var db = new DbLivrariaContext()) {
//     foreach (var autor in db.TbAutors.OrderBy(a => a.Nome)) {
//         Console.WriteLine($"O autor {autor.Nome} é do {autor.Pais}!!! ");

//     }
// }

// using (var db = new DbLivrariaContext()) {
//     foreach (var autor in db.TbAutors.Where(a => a.Nome.Contains("Machado"))) {
//         Console.WriteLine($"O autor {autor.Nome} é do {autor.Pais}!!! ");
//     }
// }


// using (var db = new DbLivrariaContext()) {
//     var autor = db.TbAutors.Find(10);

//     if (autor != null) {
//         Console.WriteLine($"O autor é {autor.Nome}");
//     }
//     else{
//         Console.WriteLine($"O autor não consta no banco");
//     }
// }

// using (var db = new DbLivrariaContext()) {
//     var novoAutor = new TbAutor
//     {
//         Nome = "Clarice Lispector",
//         NrFone = "11912345678" ,
//         Pais = "Ucrânia"
//     };

//     db.TbAutors.Add(novoAutor);
//     db.SaveChanges();
// }

using (var db = new DbLivrariaContext())
{
    var autor = db.TbAutors.SingleOrDefault(a => a.IdAutor == 6);

    if (autor != null)
    {
        db.TbAutors.Remove(autor);
        db.SaveChanges();
    } else {
        Console.WriteLine("Autor não identificado!");
    }
}