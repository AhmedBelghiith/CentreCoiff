using ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Configurations
{
    public class RDVConfiguration : IEntityTypeConfiguration<RDV>
    {
        public void Configure(EntityTypeBuilder<RDV> builder)
        {
            builder.HasOne(r => r.Prestation).WithMany(p=>p.RDVs).HasForeignKey(r=>r.PrestationFK);
            builder.HasOne(r => r.Client).WithMany(c=>c.RDVs).HasForeignKey(r=>r.ClientFK);
            builder.HasKey(r => new { r.PrestationFK, r.ClientFK, r.DateRDV }); ;
        }
    }
}
