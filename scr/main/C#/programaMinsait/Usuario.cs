using System;

class Usuario
{
    protected string nombre;
    protected string apellido;
    protected string email;
    List<Inscripciones> insc = new List<Inscripciones>();
    public string Nombre { get { return nombre; } }
    public string Apellido { get { return apellido; } }
    public string Email { get { return email; } }
    public List<Inscripciones> Insc { get { return insc; } }
    public Usuario(string nombre, string apellido, string email)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.email = email;

    }

    public void inscribirseEvento(Eventos e,Usuario u)
    {
        
        Inscripciones nuevaInsc = new Inscripciones(e,u);
        insc.Add(nuevaInsc);
        e.agregarInscripcion(nuevaInsc);
        Console.WriteLine("Inscripcion realizada correctamente");

    }
    public void cancelarInscripcion(Eventos e)
    {
        var inscripcion = insc.Find(i => i.Evento == e); //busca en la lista el primer evento con el nombre pasado por parametro
        if (inscripcion != null)
        {
            insc.Remove(inscripcion);
            e.eliminarInscripcion(inscripcion);
            Console.WriteLine("Inscripción cancelada correctamente.");
        }
        else
        {
            Console.WriteLine("No se encontró la inscripción para el evento especificado.");
        }
    }

    public void verInscripciones()
    {
        foreach (Inscripciones i in insc)
        {
            Console.WriteLine($"Evento");
        }
    }
}
