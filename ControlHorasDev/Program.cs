
class Desarrollador
{
    // Propiedades
    public string Nombre { get; set; }
    public DateTime FechaIngreso { get; set; }
    public string Email { get; set; }
    public string Categoria { get; set; }
    public List<Proyecto> ProyectosAsignados { get; set; }

    // Constructor
    public Desarrollador()
    {
        Console.WriteLine("Información del desarrollador ");
       /* 
        Nombre = nombre;
        FechaIngreso = fechaIngreso;
        Email = email;
        Categoria = categoria;
        ProyectosAsignados = new List<Proyecto>();*/
    }

    // Métodos
    public void AsignarProyecto()
    {
        Console.WriteLine("Asignar a un proyecto a un programador.");
    }

    public void RegistrarHoras()
    {
        Console.WriteLine("El programador debe registrar sus horas trabajadad en un determinado proyecto");
    }
}

// Clase Proyecto
class Proyecto
{
  
    public string Nombre { get; set; }
    public string Categoria { get; set; }
    public int Duracion { get; set; }
    public DateTime FechaInicio { get; set; }
    public Desarrollador DesarrolladorAsignado { get; set; }
    public int HorasTrabajadas { get; set; }

    // Constructor
    public Proyecto()
    {
        Console.WriteLine("Datos del proyecto");
    }

    // Métodos
    public void AsignarDesarrollador()
    {
        Console.WriteLine("Un programador es asignado a determiando proyecto.");
    }

    public void RegistrarHorasTrabajadas()
    {
        Console.WriteLine("Se registra el número de horas que se trabajan en base a a duración establecida del proyecto");
    }
}


class ControlHoras
{
    // Propiedades
    public List<Desarrollador> Desarrolladores { get; set; }//lista de desarrolladores registrados
    public List<Proyecto> Proyectos { get; set; } //lista de proyectos registrados

    // Constructor
    public ControlHoras()
    {
        Desarrolladores = new List<Desarrollador>();
        Proyectos = new List<Proyecto>();
    }

    // Métodos
    public void AgregarDesarrollador()
    {
        Console.WriteLine("Se agregan nuevos programadores");
    }

    public void AgregarProyecto()
    {
        Console.WriteLine("Se agrega un nuevo proyecto");
    }

    public void AsignarProyecto()
    {
        Console.WriteLine("Se asigna un programador a un proyecto");
       
    }

    public void RegistrarHoras()
    {
        Console.WriteLine("Un progeamador registra un determinado número de horas a determinado proyectp");
    }
}

// Clase Main
class Program
{
    static void Main(string[] args)
    {
        ControlHoras control = new ControlHoras();

        // Agregar proyectos
        Proyecto proyecto1 = new Proyecto();
        Proyecto proyecto2 = new Proyecto();
        control.AgregarProyecto();
        control.AgregarProyecto();

        // Agregar desarrolladores
        Desarrollador desarrollador1 = new Desarrollador();
        Desarrollador desarrollador2 = new Desarrollador();
        control.AgregarDesarrollador();
        control.AgregarDesarrollador();

        // Asignar proyectos a desarrolladores
        control.AsignarProyecto();
        control.AsignarProyecto();

        // Registrar horas trabajadas
        control.RegistrarHoras();
        control.RegistrarHoras();
        control.RegistrarHoras();

    }
}