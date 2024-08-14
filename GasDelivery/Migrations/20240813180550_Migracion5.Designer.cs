﻿// <auto-generated />
using System;
using GasDelivery.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GasDelivery.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20240813180550_Migracion5")]
    partial class Migracion5
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GasDelivery.Models.InfoCliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Calle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ciudad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CruceCalles")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id_InfoCliente")
                        .HasColumnType("int");

                    b.Property<string>("NoExterior")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NoInterior")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Telefono")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("InfoClientes");
                });

            modelBuilder.Entity("GasDelivery.Models.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Costo")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("EstadoPedido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("HoraLlegada")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("HoraSalida")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_InfoCliente")
                        .HasColumnType("int");

                    b.Property<int>("Id_Repartidor")
                        .HasColumnType("int");

                    b.Property<string>("MetodoPago")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TiempoEstimado")
                        .HasColumnType("int");

                    b.Property<string>("TipoServicio")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Id_InfoCliente")
                        .IsUnique();

                    b.HasIndex("Id_Repartidor");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("GasDelivery.Models.Repartidor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ComentarioEstadoRepartidor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EstadoRepartidor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Telefono")
                        .HasColumnType("int");

                    b.Property<string>("UbicacionActual")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Repartidor");
                });

            modelBuilder.Entity("GasDelivery.Models.Suscripcion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha_fin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Fecha_inicio")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_InfoCliente")
                        .HasColumnType("int");

                    b.Property<string>("Periodicidad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo_servicio")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Id_InfoCliente")
                        .IsUnique();

                    b.ToTable("Suscripciones");
                });

            modelBuilder.Entity("GasDelivery.Models.Tarjeta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("FechaVencimiento")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_Usuario")
                        .HasColumnType("int");

                    b.Property<DateTime>("Nip")
                        .HasColumnType("datetime2");

                    b.Property<int>("NumeroTarjeta")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id_Usuario");

                    b.ToTable("Tarjetas");
                });

            modelBuilder.Entity("GasDelivery.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Contrasena")
                        .HasColumnType("int");

                    b.Property<int>("Id_InfoCliente")
                        .HasColumnType("int");

                    b.Property<int>("NombreUsuario")
                        .HasColumnType("int");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id_InfoCliente")
                        .IsUnique();

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("GasDelivery.Models.Pedido", b =>
                {
                    b.HasOne("GasDelivery.Models.InfoCliente", "InfoCliente")
                        .WithOne("Pedido")
                        .HasForeignKey("GasDelivery.Models.Pedido", "Id_InfoCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GasDelivery.Models.Repartidor", "Repartidor")
                        .WithMany("Pedidos")
                        .HasForeignKey("Id_Repartidor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("InfoCliente");

                    b.Navigation("Repartidor");
                });

            modelBuilder.Entity("GasDelivery.Models.Suscripcion", b =>
                {
                    b.HasOne("GasDelivery.Models.InfoCliente", "InfoCliente")
                        .WithOne("Suscripcion")
                        .HasForeignKey("GasDelivery.Models.Suscripcion", "Id_InfoCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("InfoCliente");
                });

            modelBuilder.Entity("GasDelivery.Models.Tarjeta", b =>
                {
                    b.HasOne("GasDelivery.Models.Usuario", "Usuario")
                        .WithMany("Tarjetas")
                        .HasForeignKey("Id_Usuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("GasDelivery.Models.Usuario", b =>
                {
                    b.HasOne("GasDelivery.Models.InfoCliente", "InfoCliente")
                        .WithOne("Usuarios")
                        .HasForeignKey("GasDelivery.Models.Usuario", "Id_InfoCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("InfoCliente");
                });

            modelBuilder.Entity("GasDelivery.Models.InfoCliente", b =>
                {
                    b.Navigation("Pedido");

                    b.Navigation("Suscripcion");

                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("GasDelivery.Models.Repartidor", b =>
                {
                    b.Navigation("Pedidos");
                });

            modelBuilder.Entity("GasDelivery.Models.Usuario", b =>
                {
                    b.Navigation("Tarjetas");
                });
#pragma warning restore 612, 618
        }
    }
}
