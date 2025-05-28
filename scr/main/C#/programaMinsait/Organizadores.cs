using System;

class Organizadores : Usuario
{
    List<Eventos> listaEventosCreados = new List<Eventos>();

    public Organizadores(string nombre, string apellido, string email) : base(nombre, apellido, email)
    {

    }

    public void crearEvento(string nombre, DateTime fecha, Ubicaciones ubicacion, Categorias categoria, bool online)
    {
        Eventos nuevoEvento = new Eventos( nombre, fecha, ubicacion, categoria);
        listaEventosCreados.Add(nuevoEvento);
        Console.WriteLine($"Evento '{nombre}' creado correctamente.");
    }
   public void eliminarEvento(Eventos evento)
    {
        if (listaEventosCreados.Contains(evento))
        {
            listaEventosCreados.Remove(evento);
            Console.WriteLine($"Evento '{evento.Nombre}' eliminado correctamente.");
        }
        else
        {
            Console.WriteLine("El evento no existe en la lista de eventos creados.");
        }
    }

    public void mostrarEventosCreados()
    {
        if (listaEventosCreados.Count == 0)
        {
            Console.WriteLine("No hay eventos creados por este organizador.");
        }
        else
        {
            foreach (var evento in listaEventosCreados)
            {
                Console.WriteLine($"Evento: {evento.Nombre}, Fecha: {evento.Fecha}, Ubicación: {evento.Ubicacion}, Categoría: {evento.Categoria}");
            }
        }
    }
}