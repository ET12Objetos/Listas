using ConsoleTables;
using Usuarios;

//crear una lista
//List<Usuario> usuarios = new List<Usuario>();

//declaracion lista
List<Usuario> usuarios;

//instanciacion lista
usuarios = new List<Usuario>();

Usuario usuario1 = new Usuario
{
    Id = 1,
    NombreCompleto = "Juan",
    NombreUsuario = "juan@gmail.com",
    Constraseña = "1234"
};

Usuario usuario2 = new Usuario
{
    Id = 2,
    NombreCompleto = "Mario",
    NombreUsuario = "mario@gmail.com",
    Constraseña = "939339"
};

Usuario usuario3 = new Usuario
{
    Id = 3,
    NombreCompleto = "Manuel",
    NombreUsuario = "manuel@gmail.com",
    Constraseña = "000001"
};

Usuario usuario4 = new Usuario
{
    Id = 4,
    NombreCompleto = "Matias",
    NombreUsuario = "matias@gmail.com",
    Constraseña = "911232"
};

Usuario usuario5 = new Usuario
{
    Id = 5,
    NombreCompleto = "Jose",
    NombreUsuario = "jose@gmail.com",
    Constraseña = "11122"
};

//agregar usuarios a la lista
usuarios.Add(usuario1);
usuarios.Add(usuario2);
usuarios.Add(usuario3);
usuarios.Add(usuario4);
usuarios.Add(usuario5);

//leer una lista (con foreach)
foreach (Usuario u in usuarios)
{
    Console.WriteLine($"Id: {u.Id} Nombre: {u.NombreCompleto}");
}

//leer una lista (con for)
//Propiedad Count, indica la cantidad de elementos que contiene una lista
for (int i = 0; i < usuarios.Count; i++)
{
    Console.WriteLine($"Id: {usuarios[i].Id} Nombre: {usuarios[i].NombreCompleto}");
}

//usuarios.Sort(); no funciona, porque hay que especificar el Comparer

//Uso el paquete ConsoleTables
Console.Clear();
var table = new ConsoleTable("ID", "Nombre", "Usuario", "Contraseña");
foreach (Usuario u in usuarios)
{
    table.AddRow(u.Id, u.NombreCompleto, u.NombreUsuario, u.Constraseña);
}

table.Write();

//----------------Método Select-----------------
//Notacion Fluent
var resultadoSelect = usuarios.Select(x => new { x.Id, x.NombreUsuario });

//Notacion Query
var resultadoSelect = from x in usuarios
                      select new { x.Id, x.NombreUsuario };

Console.Clear();
var table = new ConsoleTable("ID", "Usuario");
foreach (var u in resultadoSelect)
{
    table.AddRow(u.Id, u.NombreUsuario);
}

table.Write();

//----------------Método Where-----------------
//Notacion Fluent
var resultadoWhere = usuarios.Where(x => x.Id > 1 && x.Id % 2 == 0);

//Notacion Query
var resultadoWhere = from u in usuarios
                     where u.Id > 1 && u.Id % 2 == 0
                     select u;

Console.Clear();
var table = new ConsoleTable("ID", "Nombre", "Usuario", "Contraseña");
foreach (Usuario u in resultadoWhere)
{
    table.AddRow(u.Id, u.NombreCompleto, u.NombreUsuario, u.Constraseña);
}

table.Write();

//----------------Método OrderBy-----------------
//Notacion Fluent
var resultadoOrderBy = usuarios.OrderByDescending(x => x.Id);

//Notacion Query
var resultadoOrderBy = from usuario in usuarios
                       orderby usuario.Id descending
                       select usuario;
Console.Clear();
var table = new ConsoleTable("ID", "Nombre", "Usuario", "Contraseña");
foreach (Usuario u in resultadoOrderBy)
{
    table.AddRow(u.Id, u.NombreCompleto, u.NombreUsuario, u.Constraseña);
}

table.Write();
