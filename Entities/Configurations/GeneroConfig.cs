using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IntroAEFCore.Entities.Configurations
{
    public class GeneroConfig : IEntityTypeConfiguration<Genero>
    {
        public void Configure(EntityTypeBuilder<Genero> builder){
            builder.Property(x => x.Nombre).HasMaxLength(150);
        }
        

        
    }
}