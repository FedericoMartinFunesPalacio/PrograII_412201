﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RepasoParcialCine.Models;

public partial class Generos
{
    public int Id { get; set; }

    public string Nombre { get; set; }

    public virtual ICollection<Peliculas> Peliculas { get; set; } = new List<Peliculas>();
}