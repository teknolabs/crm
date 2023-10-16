using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TeknoLabs.Crm.Domain.ClientEntities;
using TeknoLabs.Crm.Persistance.Constans;

namespace TeknoLabs.Crm.Persistance.Configurations
{
    public sealed class UCAFConfiguration : IEntityTypeConfiguration<UniformChartOfAccount>
    {
        public void Configure(EntityTypeBuilder<UniformChartOfAccount> builder)
        {
            builder.ToTable(TableNames.UniformChartOfAccount);
            builder.HasKey("Id");
        }
    }
}
