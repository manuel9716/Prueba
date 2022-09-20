using System;
using proyectoef;
using proyectoef.Models;


public class FormulacionService : IFormulacionService
{
    TareasContext context;

    public FormulacionService(TareasContext dbcontext)
    {
        context = dbcontext;
    }

    public IEnumerable<Formulacion> Get()
    {
        return context.formulaciones;
    }

    public async Task Save(Formulacion formulacion)
    {
        context.Add(formulacion);
        await context.SaveChangesAsync();
    }

    public async Task Update(Guid id, Formulacion formulacion)
    {
        var formulacionActual = context.formulaciones.Find(id);

        if(formulacionActual != null)
        {
            formulacionActual.ID_PRY = formulacion.ID_PRY;
            formulacionActual.ID_TIPO_PRY = formulacion.ID_TIPO_PRY;
            formulacionActual.ID_SUBTIPO_PRY = formulacion.ID_SUBTIPO_PRY;
            formulacionActual.FCH_FORMULACION = formulacion.FCH_FORMULACION;
            formulacionActual.VALOR_PRY_BPS = formulacion.VALOR_PRY_BPS;
            formulacionActual.VALOR_PRY_SENA = formulacion.VALOR_PRY_SENA;
            formulacionActual.VALOR_OTROS = formulacion.VALOR_OTROS;
            formulacionActual.ID_ESTADO_BPS = formulacion.ID_ESTADO_BPS;
            formulacionActual.ID_ESTADO_PRIORI = formulacion.ID_ESTADO_PRIORI;
            formulacionActual.ID_PRIORIZACION = formulacion.ID_PRIORIZACION;
            formulacionActual.ID_ESTADO_AUD = formulacion.ID_ESTADO_AUD;
            formulacionActual.FCH_CARGA = formulacion.FCH_CARGA;
            formulacionActual.FCH_ACTUALIZA = formulacion.FCH_ACTUALIZA;

        
            await context.SaveChangesAsync();
        }
        
        
    }

    public async Task Delete(Guid id)
    {
        var formuacionActual = context.formulaciones.Find(id);

        if(formuacionActual != null)
        {
            context.Remove(formuacionActual);
        
            await context.SaveChangesAsync();
        }
        
        
    }

}

public interface IFormulacionService
{
    IEnumerable<Formulacion> Get();
    Task Save(Formulacion formulacion);
    Task Update(Guid id, Formulacion formulacion);
    Task Delete(Guid id);
}