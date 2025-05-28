using System;

class Inscripciones
{
   
    Eventos evento;
    Usuario user;

    public Inscripciones( Eventos evento, Usuario user)
    {
       
        this.evento = evento;
        this.user = user;
    }

    public Eventos Evento
    {
        get { return evento; }
    }
    public Usuario User
    {
        get { return user; }
    }

}

