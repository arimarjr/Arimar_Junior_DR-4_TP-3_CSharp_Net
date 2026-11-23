// Exercício: 5, 6
using CityBreaks.Web.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CityBreaks.Web.Data.Configurations
{
    public class PropertyConfiguration : IEntityTypeConfiguration<Property>
    {
        public void Configure(EntityTypeBuilder<Property> builder)
        {
            builder.Property(p => p.Name)
                .HasMaxLength(150)
                .HasColumnName("Property_Name");

            builder.Property(p => p.PricePerNight)
                .HasColumnName("Price_Per_Night");

            builder.HasData(
                new Property { Id = 1, Name = "Hotel Copacabana", PricePerNight = 450.00m, CityId = 1 },
                new Property { Id = 2, Name = "Pousada Santa Teresa", PricePerNight = 180.50m, CityId = 1 },
                new Property { Id = 3, Name = "Hotel Paulista", PricePerNight = 320.00m, CityId = 2 },
                new Property { Id = 4, Name = "Hostel Alfama", PricePerNight = 75.00m, CityId = 3 },
                new Property { Id = 5, Name = "Hotel Baixa", PricePerNight = 210.00m, CityId = 3 },
                new Property { Id = 6, Name = "Casa da Ribeira", PricePerNight = 130.00m, CityId = 4 },
                new Property { Id = 7, Name = "Hotel Coliseu", PricePerNight = 390.00m, CityId = 5 },
                new Property { Id = 8, Name = "Palazzo Canal", PricePerNight = 620.00m, CityId = 6 },
                new Property { Id = 9, Name = "Hostel Trastevere", PricePerNight = 60.00m, CityId = 5 });
        }
    }
}
