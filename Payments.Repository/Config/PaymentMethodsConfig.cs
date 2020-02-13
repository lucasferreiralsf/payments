using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Payments.Domain.ValueObjects;

namespace Payments.Repository.Config
{
    public class PaymentMethodsConfig: IEntityTypeConfiguration<PaymentMethods>
    {
        public void Configure(EntityTypeBuilder<PaymentMethods> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).IsRequired().HasMaxLength(128);
            builder.Property(p => p.Description).HasMaxLength(300);
        }
    }
}
