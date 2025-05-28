using System;
class Ubicaciones
{
    bool online = false;
    string dir;
    DateTime fecha;
    public bool Online
    {
        get { return online; }
        set { online = value; }
    }

    public string Dir
    {
        get { return dir; }
        set { dir = value; }
    }

    public DateTime Fecha
    {
        get { return fecha; }
        set { fecha = value; }
    }
    public Ubicaciones(bool online, string dir, DateTime fecha)
    {
        this.online = online;
        this.dir = dir;
        this.fecha = fecha;
    }
    
}