using GymAppLecture.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymAppLecture.Configurations
{
    public class PlanConfiguration : IEntityTypeConfiguration<Plan>
    {
        public void Configure(EntityTypeBuilder<Models.Plan> builder)
        {
            builder.Property(X => X.Name)
                .HasMaxLength(100)
                .HasColumnType ("Varchar(100)");
            builder.Property(X => X.Description)
                .HasMaxLength(500)
                .HasColumnName("Varchar(500)");

            builder.Property(X => X.Price)
                .HasPrecision(10, 2);

            builder.Property(X => X.CreatedAt)
                .HasDefaultValueSql("GETDATE()");

            builder.ToTable(tb => tb.HasCheckConstraint("CK_Plan_DurationDays", "DurationDays Between 1 and 365"));
        }

    }
}
