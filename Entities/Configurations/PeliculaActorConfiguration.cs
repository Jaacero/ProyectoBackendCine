using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace IntroAEFCore.Entities.Configurations
{
    public class PeliculaActorConfiguration: IEntityTypeConfiguration<PeliculaActor>
    {
        public void Configure(EntityTypeBuilder<PeliculaActor> builder){
            builder.HasKey(pa => new{pa.ActorId , pa.PeliculaId});
        }
    }
}