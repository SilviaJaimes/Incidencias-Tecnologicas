namespace Dominio.Entities;
public class Genero : BaseEntity
{
    public string Descipcion { get; set; }
    public ICollection<Persona> Personas { get; set; }
}