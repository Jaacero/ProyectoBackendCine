using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace IntroAEFCore.Entities.Configurations
{
    public class ActorConfig : IEntityTypeConfiguration<Actor>
    {
        public void Configure(EntityTypeBuilder<Actor> builder){
            //builder.Property(ac => ac.FechaNacimineto).HasColumnType("date");
            builder.Property(ac => ac.Fortuna).HasMaxLength(500);
        }
        
    }
}