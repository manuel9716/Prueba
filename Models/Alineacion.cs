
namespace proyectoef.Models;

public class Alineacion
{
    //[Key]//la clave de la tabla Tareas
    public Guid ID_ALINEACION_PRY {get;set;}

    public int ID_PRY {get;set;}

    public int ID_TIPO_ALINEACION {get;set;}

    public int ID_ESTADO_AUD {get;set;}

    public DateTime FCH_CARGA {get;set;}

    public DateTime FCH_ACTUALIZA {get;set;}
    

}

