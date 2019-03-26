using Generales.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Generales.EF.Configurations
{
    public class ClasificacionesConfiguration : IEntityTypeConfiguration<Clasificacion>
    {
        public void Configure(EntityTypeBuilder<Clasificacion> builder)
        {
            builder
                .ToTable("Clasificaciones", "Generales")
                .HasKey(k => k.ID_Clasificacion);
        }
    }
}
