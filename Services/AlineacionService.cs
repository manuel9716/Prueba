using proyectoef;
using proyectoef.Models;

namespace webapi.Services;

public class AlineacionService : IAlineacionService
{

    TareasContext context;

    public AlineacionService(TareasContext dbcontext)
    {
        context = dbcontext;
    }
    public IEnumerable<Alineacion> Get()
    {
        return context.Alineaciones;
    }

    public async Task Save(Alineacion alineacion)
    {
        context.Add(alineacion);
        await context.SaveChangesAsync();
    }

    public async Task Update(Guid id, Alineacion alineacion)
    {
        var alineacionActual = context.Alineaciones.Find(id);

        if(alineacionActual != null)
        {
            alineacionActual.ID_PRY = alineacion.ID_PRY;
            alineacionActual.ID_TIPO_ALINEACION = alineacion.ID_TIPO_ALINEACION;
            alineacionActual.ID_ESTADO_AUD = alineacion.ID_ESTADO_AUD;
            alineacionActual.FCH_CARGA = alineacion.FCH_CARGA;
            alineacionActual.FCH_ACTUALIZA = alineacion.FCH_ACTUALIZA;
        
            await context.SaveChangesAsync();
        }
        
        
    }

    public async Task Delete(Guid id)
    {
        var alineacionActual = context.Alineaciones.Find(id);

        if(alineacionActual != null)
        {
            context.Remove(alineacionActual);
        
            await context.SaveChangesAsync();
        }
        
        
    }

}

public interface IAlineacionService
{
    IEnumerable<Alineacion> Get();
    Task Save(Alineacion alineacion);
    Task Update(Guid id, Alineacion alineacion);
    Task Delete(Guid id);
}