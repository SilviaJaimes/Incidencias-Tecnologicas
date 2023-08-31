/* using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class TrainerSalonConfiguration : IEntityTypeConfiguration<TrainerSalon>
{
    public void Configure(EntityTypeBuilder<TrainerSalon> builder)
    {
        builder.ToTable("trainerSalon");

        builder.Property(tp => tp.IdPersonaFk)
        .HasMaxLength(20);

        builder.HasOne(tp => tp.Persona)
        .WithMany(tp => tp.TrainerSalones)
        .HasForeignKey(tp => tp.IdPersonaFk);

        builder.Property(tp => tp.IdSalonFk)
        .HasMaxLength(20);

        builder.HasOne(tp => tp.Salon)
        .WithMany(tp => tp.TrainerSalones)
        .HasForeignKey(tp => tp.IdSalonFk);
    }
} */