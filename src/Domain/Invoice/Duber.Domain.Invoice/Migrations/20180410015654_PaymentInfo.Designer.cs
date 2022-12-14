// <auto-generated />
using Duber.Domain.Invoice.Model;
using Duber.Domain.Invoice.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
#pragma warning disable 618

namespace Duber.Domain.Invoice.Migrations
{
    [DbContext(typeof(InvoiceMigrationContext))]
    [Migration("20180410015654_PaymentInfo")]
    partial class PaymentInfo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Duber.Domain.Invoice.Model.Invoice", b =>
                {
                    b.Property<Guid>("InvoiceId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<double>("Distance");

                    b.Property<TimeSpan>("Duration");

                    b.Property<decimal>("Fee");

                    b.Property<int>("PaymentMethodId");

                    b.Property<decimal>("Total");

                    b.Property<Guid>("TripId");

                    b.Property<int>("TripStatusId");

                    b.HasKey("InvoiceId");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("Duber.Domain.Invoice.Model.PaymentInfo", b =>
                {
                    b.Property<int>("Status");

                    b.Property<string>("CardNumber");

                    b.Property<string>("CardType");

                    b.Property<Guid>("InvoiceId");

                    b.Property<int>("UserId");

                    b.HasKey("Status", "CardNumber", "CardType", "InvoiceId", "UserId");

                    b.HasIndex("InvoiceId")
                        .IsUnique();

                    b.ToTable("PaymentsInfo");
                });

            modelBuilder.Entity("Duber.Domain.Invoice.Model.PaymentInfo", b =>
                {
                    b.HasOne("Duber.Domain.Invoice.Model.Invoice")
                        .WithOne("PaymentInfo")
                        .HasForeignKey("Duber.Domain.Invoice.Model.PaymentInfo", "InvoiceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
