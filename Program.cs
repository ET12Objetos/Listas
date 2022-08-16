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
    Contraseña = "1234"
};

Usuario usuario2 = new Usuario
{
    Id = 2,
    NombreCompleto = "Mario",
    NombreUsuario = "mario@gmail.com",
    Contraseña = "939339"
};

Usuario usuario3 = new Usuario
{
    Id = 4,
    NombreCompleto = "Manuel",
    NombreUsuario = "manuel@gmail.com",
    Contraseña = "000001"
};

Usuario usuario4 = new Usuario
{
    Id = 4,
    NombreCompleto = "Matias",
    NombreUsuario = "matias@gmail.com",
    Contraseña = "911232"
};

Usuario usuario5 = new Usuario
{
    Id = 4,
    NombreCompleto = "Jose",
    NombreUsuario = "jose@gmail.com",
    Contraseña = "11122"
};

//agregar usuarios a la lista
usuarios.Add(usuario1);
usuarios.Add(usuario2);
usuarios.Add(usuario3);
usuarios.Add(usuario4);
usuarios.Add(usuario5);

//--------------- ForEach----------------
//leer una lista (con método foreach)
Console.Clear();
var table = new ConsoleTable("ID", "Nombre", "Usuario", "Contraseña");
//ciclo de iteracion ForEach
foreach (Usuario u in usuarios)
{
    table.AddRow(u.Id, u.NombreCompleto, u.NombreUsuario, u.Contraseña);
}

//Metodo con mas de una linea, se usan {}
usuarios.ForEach(u =>
{
    table.AddRow(u.Id, u.NombreCompleto, u.NombreUsuario, u.Contraseña);
});

usuarios.ForEach(u =>
    table.AddRow(u.Id, u.NombreCompleto, u.NombreUsuario, u.Contraseña));

table.Write();

//--------------- All ----------------
bool resultado1 = usuarios.All(x => x.Id > 0);
System.Console.WriteLine($"Resultado All: {resultado1}");

bool resultado2 = usuarios.All(x => x.Id > 3 && x.Id < 10);
System.Console.WriteLine($"Resultado All: {resultado2}");

//--------------- Any ----------------
bool resultado3 = usuarios.Any(x => x.Id > 4);
System.Console.WriteLine($"Resultado Any: {resultado3}");

bool resultado4 = usuarios.Any(x => x.Id == 100);
System.Console.WriteLine($"Resultado Any: {resultado4}");

//--------------- First ----------------
var resultado = usuarios.First(x => x.Id == 2);
Console.WriteLine($"Id: {resultado.Id} Nombre: {resultado.NombreCompleto}");

//Aclaracion: si la condicion del First no se cumple, se lanza una excepcion
//corta la ejecucion del programa
var resultadoFirst2 = usuarios.First(x => x.Id == 1000);
Console.WriteLine($"Id: {resultadoFirst2.Id} Nombre: {resultadoFirst2.NombreCompleto}");

//--------------- FirstOrDefault ----------------
//Aclaracion: si la condicion del FirstOrDefault no se cumple, retorna NULL
var resultadoFirst3 = usuarios.FirstOrDefault(x => x.Id == 4);

if (resultadoFirst3 != null)
    Console.WriteLine($"Id: {resultadoFirst3.Id} Nombre: {resultadoFirst3.NombreCompleto}");

//--------------- Last ----------------
var resultadoLast1 = usuarios.Last(x => x.Id == 2);
Console.WriteLine($"Id: {resultadoLast1.Id} Nombre: {resultadoLast1.NombreCompleto}");

//Aclaracion: si la condicion del First no se cumple, se lanza una excepcion
//corta la ejecucion del programa
var resultadoFirst2 = usuarios.First(x => x.Id == 1000);
Console.WriteLine($"Id: {resultadoFirst2.Id} Nombre: {resultadoFirst2.NombreCompleto}");

//--------------- LastOrDefault ----------------
//Aclaracion: si la condicion del FirstOrDefault no se cumple, retorna NULL
var resultadoLast2 = usuarios.LastOrDefault(x => x.Id == 4);

if (resultadoLast2 != null)
    Console.WriteLine($"Id: {resultadoLast2.Id} Nombre: {resultadoLast2.NombreCompleto}");

//--------------- Uso de First o Last con Where ----------------
var resultadoWhere1 = usuarios.Where(x => x.Id == 4).First();
var resultadoWhere2 = usuarios.Where(x => x.Id == 2000).FirstOrDefault();
var resultadoWhere3 = usuarios.Where(x => x.Id == 4).Last();
var resultadoWhere4 = usuarios.Where(x => x.Id == 3000).LastOrDefault();
