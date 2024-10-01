﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Problema2_7_412201_IngIndirecta.Models;

public partial class Problema2_7Context : DbContext
{
    public Problema2_7Context(DbContextOptions<Problema2_7Context> options)
        : base(options)
    {
    }

    public virtual DbSet<DetalleTurnos> DetalleTurnos { get; set; }

    public virtual DbSet<Servicios> Servicios { get; set; }

    public virtual DbSet<Turnos> Turnos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DetalleTurnos>(entity =>
        {
            entity.HasKey(e => e.IdDetalle);

            entity.HasIndex(e => e.ServicioIdServicio, "IX_DetalleTurnos_ServicioIdServicio");

            entity.HasIndex(e => e.TurnoIdTurno, "IX_DetalleTurnos_TurnoIdTurno");

            entity.HasOne(d => d.ServicioIdServicioNavigation).WithMany(p => p.DetalleTurnos).HasForeignKey(d => d.ServicioIdServicio);

            entity.HasOne(d => d.TurnoIdTurnoNavigation).WithMany(p => p.DetalleTurnos).HasForeignKey(d => d.TurnoIdTurno);
        });

        modelBuilder.Entity<Servicios>(entity =>
        {
            entity.HasKey(e => e.IdServicio);

            entity.Property(e => e.Nombre).IsRequired();
        });

        modelBuilder.Entity<Turnos>(entity =>
        {
            entity.HasKey(e => e.IdTurno);

            entity.Property(e => e.Cliente).IsRequired();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}