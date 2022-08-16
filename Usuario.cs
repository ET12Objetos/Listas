namespace Usuarios;
public class Usuario
{
    public int Id { get; set; }
    public string NombreCompleto { get; set; } = null!;
    public string Contraseña { get; set; } = null!;
    public string NombreUsuario { get; set; } = null!;
}