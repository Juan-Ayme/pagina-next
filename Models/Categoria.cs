using System.ComponentModel.DataAnnotations;

namespace proyectoef.Models;

public class Categoria{
    [Key]
    public Guid CategoriaId{get;set;}

    [Required]//Esrequerido el nombre OBLIGATORIO
    [MaxLength(150)]//maximo caracteres
    public string Nombre{get;set;}
    public string Descripcion{get;set;}
    public virtual ICollection<Tarea> Tareas{get;set;}
}