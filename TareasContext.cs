using Microsoft.EntityFrameworkCore;
using proyectoef.Models;
//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace proyectoef;

public class TareasContext: DbContext
{

    public DbSet<Alineacion> Alineaciones {get;set;}

    public DbSet<Formulacion> formulaciones {get;set;}

    //public DbSet<Autenticacion> Autenticaciones {get;set;}

    public TareasContext(DbContextOptions<TareasContext> options) :base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //base.OnModelCreating(modelBuilder);

        /* List<Autenticacion> AutenticacionInit = new List<Autenticacion>();

        AutenticacionInit.Add(new Autenticacion() { ID_USUARIO = Guid.Parse("fe2de405-c38e-4c90-ac52-da0540dfb410"), NAME_USUARIO = 1,  PASSPORT =  1, Rol = 1 });

        modelBuilder.Entity<Autenticacion>(autenticacion=>
        {
            autenticacion.ToTable("Autenticacion");
            autenticacion.HasKey(p=> p.ID_USUARIO);

            autenticacion.Property(p=> p.NAME_USUARIO);

            autenticacion.Property(p=> p.PASSPORT);

            autenticacion.Property(p=> p.Rol);


        });*/
        

        List<Alineacion> AlineacionesInit = new List<Alineacion>();

        AlineacionesInit.Add(new Alineacion() { ID_ALINEACION_PRY = Guid.Parse("fe2de405-c38e-4c90-ac52-da0540dfb410"), FCH_CARGA = DateTime.Now,  FCH_ACTUALIZA = DateTime.Now });
        AlineacionesInit.Add(new Alineacion() { ID_ALINEACION_PRY = Guid.Parse("fe2de405-c38e-4c90-ac52-da0540dfb411"), FCH_CARGA = DateTime.Now, FCH_ACTUALIZA = DateTime.Now });

        modelBuilder.Entity<Alineacion>(alineacion=>
        {
            alineacion.ToTable("Alineacion");
            alineacion.HasKey(p=> p.ID_ALINEACION_PRY);

            alineacion.Property(p=> p.ID_PRY);

            alineacion.Property(p=> p.ID_TIPO_ALINEACION);

            alineacion.Property(p=> p.ID_ESTADO_AUD);

            alineacion.Property(p=> p.FCH_CARGA);

            alineacion.Property(p=> p.FCH_ACTUALIZA);

            alineacion.HasData(AlineacionesInit);

        });

        List<Formulacion> formulacionesInit = new List<Formulacion>();
        formulacionesInit.Add(new Formulacion() { ID_FORMULACION = Guid.Parse("fe2de405-c38e-4c90-ac52-da0540dfb4ef"), FCH_FORMULACION = DateTime.Now, FCH_CARGA = DateTime.Now,  FCH_ACTUALIZA = DateTime.Now});
        formulacionesInit.Add(new Formulacion() { ID_FORMULACION = Guid.Parse("fe2de405-c38e-4c90-ac52-da0540dfb402"), FCH_FORMULACION = DateTime.Now, FCH_CARGA = DateTime.Now,  FCH_ACTUALIZA = DateTime.Now});


        modelBuilder.Entity<Formulacion>(formulacion=> 
        {
            formulacion.ToTable("Formulacion");
            formulacion.HasKey(p=> p.ID_FORMULACION);

            formulacion.Property(p=> p.ID_PRY);

            formulacion.Property(p=> p.ID_TIPO_PRY);

            formulacion.Property(p=> p.ID_SUBTIPO_PRY);

            formulacion.Property(p=> p.FCH_FORMULACION);

            formulacion.Property(p=> p.VALOR_PRY_BPS);

            formulacion.Property(p=> p.VALOR_PRY_SENA);

            formulacion.Property(p=> p.VALOR_OTROS);

            formulacion.Property(p=> p.ID_ESTADO_BPS);

            formulacion.Property(p=> p.ID_ESTADO_PRIORI);

            formulacion.Property(p=> p.ID_PRIORIZACION);

            formulacion.Property(p=> p.ID_ESTADO_AUD);

            formulacion.Property(p=> p.FCH_CARGA);

            formulacion.Property(p=> p.FCH_ACTUALIZA);



            
        });
       
    }
}