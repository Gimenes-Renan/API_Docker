﻿// <auto-generated />
using System;
using API_Docker.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace API_Docker.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    [Migration("20221006191925_AdicionadoDataExpiracao")]
    partial class AdicionadoDataExpiracao
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("API_Docker.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DataCriacao")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("data");

                    b.Property<DateTime?>("DataExpiracao")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("expiracao");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("descricao");

                    b.Property<double>("Valor")
                        .HasColumnType("double precision")
                        .HasColumnName("valor");

                    b.HasKey("Id");

                    b.ToTable("categoriateste2");
                });
#pragma warning restore 612, 618
        }
    }
}
