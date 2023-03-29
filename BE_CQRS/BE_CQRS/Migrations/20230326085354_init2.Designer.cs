﻿// <auto-generated />
using System;
using BE_CQRS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BE_CQRS.Migrations
{
    [DbContext(typeof(PostgreDbContext))]
    [Migration("20230326085354_init2")]
    partial class init2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BE_CQRS.Models.Entities.Core.DetailInformationTypeProduct", b =>
                {
                    b.Property<int>("InformationTypeProductId")
                        .HasColumnType("integer");

                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DateDeleted")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("date");

                    b.Property<int>("Id")
                        .HasColumnType("integer");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<int?>("UserCreated")
                        .HasColumnType("integer");

                    b.Property<int?>("UserDeleted")
                        .HasColumnType("integer");

                    b.Property<int?>("UserUpdated")
                        .HasColumnType("integer");

                    b.HasKey("InformationTypeProductId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("DetailInformationTypeProduct", "public");
                });

            modelBuilder.Entity("BE_CQRS.Models.Entities.Core.InformationProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DateDeleted")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("date");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<int?>("UserCreated")
                        .HasColumnType("integer");

                    b.Property<int?>("UserDeleted")
                        .HasColumnType("integer");

                    b.Property<int?>("UserUpdated")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("InformationProduct", "public");
                });

            modelBuilder.Entity("BE_CQRS.Models.Entities.Core.InformationTypeProduct", b =>
                {
                    b.Property<int>("InformationProductId")
                        .HasColumnType("integer");

                    b.Property<int>("TypeProductId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DateDeleted")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("date");

                    b.Property<int>("Id")
                        .HasColumnType("integer");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<int?>("UserCreated")
                        .HasColumnType("integer");

                    b.Property<int?>("UserDeleted")
                        .HasColumnType("integer");

                    b.Property<int?>("UserUpdated")
                        .HasColumnType("integer");

                    b.HasKey("InformationProductId", "TypeProductId");

                    b.HasIndex("TypeProductId");

                    b.ToTable("InformationTypeProduct", "public");
                });

            modelBuilder.Entity("BE_CQRS.Models.Entities.Core.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DateDeleted")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("date");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<int>("Price")
                        .HasColumnType("integer");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.Property<int>("TypeProductId")
                        .HasColumnType("integer");

                    b.Property<int?>("UserCreated")
                        .HasColumnType("integer");

                    b.Property<int?>("UserDeleted")
                        .HasColumnType("integer");

                    b.Property<int?>("UserUpdated")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("TypeProductId");

                    b.ToTable("Product", "public");
                });

            modelBuilder.Entity("BE_CQRS.Models.Entities.Core.ProductUnit", b =>
                {
                    b.Property<int>("UnitId")
                        .HasColumnType("integer");

                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DateDeleted")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("date");

                    b.Property<int>("Id")
                        .HasColumnType("integer");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<int?>("UserCreated")
                        .HasColumnType("integer");

                    b.Property<int?>("UserDeleted")
                        .HasColumnType("integer");

                    b.Property<int?>("UserUpdated")
                        .HasColumnType("integer");

                    b.HasKey("UnitId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductUnit", "public");
                });

            modelBuilder.Entity("BE_CQRS.Models.Entities.Core.TypeProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DateDeleted")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("date");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<int>("TypeUnitId")
                        .HasColumnType("integer");

                    b.Property<int?>("UserCreated")
                        .HasColumnType("integer");

                    b.Property<int?>("UserDeleted")
                        .HasColumnType("integer");

                    b.Property<int?>("UserUpdated")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("TypeUnitId");

                    b.ToTable("TypeProduct", "public");
                });

            modelBuilder.Entity("BE_CQRS.Models.Entities.Core.TypeUnit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DateDeleted")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("date");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<int?>("UserCreated")
                        .HasColumnType("integer");

                    b.Property<int?>("UserDeleted")
                        .HasColumnType("integer");

                    b.Property<int?>("UserUpdated")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("TypeUnit", "public");
                });

            modelBuilder.Entity("BE_CQRS.Models.Entities.Core.Unit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DateDeleted")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("date");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<int>("StanderNumber")
                        .HasColumnType("integer");

                    b.Property<int>("TypeUnitId")
                        .HasColumnType("integer");

                    b.Property<int?>("UserCreated")
                        .HasColumnType("integer");

                    b.Property<int?>("UserDeleted")
                        .HasColumnType("integer");

                    b.Property<int?>("UserUpdated")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("TypeUnitId");

                    b.ToTable("Unit", "public");
                });

            modelBuilder.Entity("BE_CQRS.Models.Entities.Core.DetailInformationTypeProduct", b =>
                {
                    b.HasOne("BE_CQRS.Models.Entities.Core.InformationTypeProduct", "InformationTypeProduct")
                        .WithMany("DetailInformationTypeProduct")
                        .HasForeignKey("InformationTypeProductId")
                        .HasPrincipalKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_InfoTypePro_DetailInfoTypePro");

                    b.HasOne("BE_CQRS.Models.Entities.Core.Product", "Product")
                        .WithMany("DetailProductInformation")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Pro_DetailPro");

                    b.Navigation("InformationTypeProduct");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("BE_CQRS.Models.Entities.Core.InformationTypeProduct", b =>
                {
                    b.HasOne("BE_CQRS.Models.Entities.Core.InformationProduct", "InformationProduct")
                        .WithMany("InformationTypeProduct")
                        .HasForeignKey("InformationProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_InfoPro_InfoTypePro");

                    b.HasOne("BE_CQRS.Models.Entities.Core.TypeProduct", "TypeProduct")
                        .WithMany("InformationTypeProduct")
                        .HasForeignKey("TypeProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_TypePro_InfoTypePro");

                    b.Navigation("InformationProduct");

                    b.Navigation("TypeProduct");
                });

            modelBuilder.Entity("BE_CQRS.Models.Entities.Core.Product", b =>
                {
                    b.HasOne("BE_CQRS.Models.Entities.Core.TypeProduct", "TypeProduct")
                        .WithMany("Product")
                        .HasForeignKey("TypeProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_TypePro_Pro");

                    b.Navigation("TypeProduct");
                });

            modelBuilder.Entity("BE_CQRS.Models.Entities.Core.ProductUnit", b =>
                {
                    b.HasOne("BE_CQRS.Models.Entities.Core.Product", "Product")
                        .WithMany("ProductUnit")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Product_ProUnit");

                    b.HasOne("BE_CQRS.Models.Entities.Core.Unit", "Unit")
                        .WithMany("ProductUnit")
                        .HasForeignKey("UnitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Unit_ProUnit");

                    b.Navigation("Product");

                    b.Navigation("Unit");
                });

            modelBuilder.Entity("BE_CQRS.Models.Entities.Core.TypeProduct", b =>
                {
                    b.HasOne("BE_CQRS.Models.Entities.Core.TypeUnit", "TypeUnit")
                        .WithMany("TypeProduct")
                        .HasForeignKey("TypeUnitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_InfoPro_DetailInfoPro");

                    b.Navigation("TypeUnit");
                });

            modelBuilder.Entity("BE_CQRS.Models.Entities.Core.Unit", b =>
                {
                    b.HasOne("BE_CQRS.Models.Entities.Core.TypeUnit", "TypeUnit")
                        .WithMany("Unit")
                        .HasForeignKey("TypeUnitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_TypeUnit_Unit");

                    b.Navigation("TypeUnit");
                });

            modelBuilder.Entity("BE_CQRS.Models.Entities.Core.InformationProduct", b =>
                {
                    b.Navigation("InformationTypeProduct");
                });

            modelBuilder.Entity("BE_CQRS.Models.Entities.Core.InformationTypeProduct", b =>
                {
                    b.Navigation("DetailInformationTypeProduct");
                });

            modelBuilder.Entity("BE_CQRS.Models.Entities.Core.Product", b =>
                {
                    b.Navigation("DetailProductInformation");

                    b.Navigation("ProductUnit");
                });

            modelBuilder.Entity("BE_CQRS.Models.Entities.Core.TypeProduct", b =>
                {
                    b.Navigation("InformationTypeProduct");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("BE_CQRS.Models.Entities.Core.TypeUnit", b =>
                {
                    b.Navigation("TypeProduct");

                    b.Navigation("Unit");
                });

            modelBuilder.Entity("BE_CQRS.Models.Entities.Core.Unit", b =>
                {
                    b.Navigation("ProductUnit");
                });
#pragma warning restore 612, 618
        }
    }
}
