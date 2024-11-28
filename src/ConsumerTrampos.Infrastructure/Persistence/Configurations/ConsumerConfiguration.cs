using ConsumerTrampos.Domain.Consumers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsumerTrampos.Infrastructure.Persistence.Configurations;

public class ConsumerConfiguration : IEntityTypeConfiguration<Consumer>
{
    public void Configure(EntityTypeBuilder<Consumer> builder)
    {
        builder.ToTable("Consumers");

        builder.HasKey(c => c.Id);

        builder.Property(c => c.Id)
            .ValueGeneratedOnAdd();

        builder.Property(c => c.CompanyName)
            .HasMaxLength(255)
            .IsRequired();

        builder.Property(c => c.CompanySize)
            .IsRequired();
    }
}