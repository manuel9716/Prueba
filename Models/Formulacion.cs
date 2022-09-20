
namespace proyectoef.Models;

//clases
public class Formulacion
{

    //[Key]
    //Atributos
    public Guid ID_FORMULACION {get;set;}

    //[Required]//forzar a que este atributo sea requerido para la base de datos
    //[MaxLength(150)]//maximo de caracteres admitidos
    public int ID_PRY {get;set;}

    public int ID_TIPO_PRY {get;set;}

    public int ID_SUBTIPO_PRY {get;set;}

    public DateTime FCH_FORMULACION {get;set;}

    public int VALOR_PRY_BPS {get;set;}

     public int VALOR_PRY_SENA {get;set;}

    public int VALOR_OTROS {get;set;}

    public int ID_ESTADO_BPS {get;set;}

    public int ID_ESTADO_PRIORI {get;set;}

     public int ID_PRIORIZACION {get;set;}

    public int ID_ESTADO_AUD {get;set;}

    public DateTime FCH_CARGA {get;set;}

    public DateTime FCH_ACTUALIZA {get;set;}



}