using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Domain.Entities.EntityConfiguration
{
    public class StudentConfiguration : EntityTypeConfiguration<Student>
    {
        public StudentConfiguration()
        {
            Property(s => s.lastName)
                .IsRequired()
                .HasMaxLength(50);

            Property(s => s.firstName)
                .IsRequired()
                .HasMaxLength(50);

            Property(s => s.address)
                .IsRequired()
                .HasMaxLength(200);

            Property(s => s.phone)
                .IsRequired()
                .HasMaxLength(10);


            Property(s => s.enrollmentDate)
                .IsRequired();

        }
    }
}
