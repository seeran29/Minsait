using System;

class Eventos
{
    private static int id;
    private string nombre;
    private DateTime fecha;
    private Ubicaciones ub;
    private Categorias cat;

    private List<Inscripciones> listaInscripciones = new List<Inscripciones>();

    public int Id { get { return id; } }
    public string Nombre { get { return nombre; } set { nombre = value; } }
    public DateTime Fecha { get { return fecha; } set { fecha = value; } }
    public Ubicaciones Ubicacion { get { return ub; } set { ub = value; } }
    public Categorias Categoria { get { return cat; } set { cat = value; } }
    public List<Inscripciones> ListaInscripciones { get { return listaInscripciones; } }

    public Eventos(string nombre, DateTime fecha, Ubicaciones ub, Categorias cat)
    {
        this.nombre = nombre;
        this.fecha = fecha;
        this.ub = ub;
        this.cat = cat;
      
        
    }

    public void mostrarInscripciones()
    {
        if (listaInscripciones.Count == 0)
        {
            Console.WriteLine("No hay inscripciones para este evento.");
        }
        else
        {
            foreach (Inscripciones i in listaInscripciones)
            {
                Console.WriteLine($"Usuario: {i.User.Nombre}");
            }
        }
    }

    public void agregarInscripcion(Inscripciones i)
    {
        if (i == null)
        {
            Console.WriteLine("Inscripción no válida.");
        }
        else
        {
            listaInscripciones.Add(i);
            Console.WriteLine("Inscripción agregada correctamente.");
        }

    }
     public void eliminarInscripcion(Inscripciones i)
    {
        if (i == null)
        {
            Console.WriteLine("Inscripción no válida.");
        }
        else
        {
            if (listaInscripciones.Contains(i))
            {
                listaInscripciones.Remove(i);
                Console.WriteLine("Inscripción eliminada correctamente.");
            }
            else
            {
                Console.WriteLine("La inscripción no existe en la lista.");
            }
        }

    }

}