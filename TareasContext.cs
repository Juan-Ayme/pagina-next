using Microsoft.EntityFrameworkCore;
using proyectoef.Models;

namespace proyectoef;

//DbContext nos ayuda a conectar a la base de datos y interactuar
public class TareasContext:  DbContext{
    //DbSet representan las tablas de la base de datos
    public DbSet<Categoria> Categorias {get;set;}
    public DbSet<Tarea> Tareas{get;set;}

    public TareasContext(DbContextOptions<TareasContext> options):base(options){}
}