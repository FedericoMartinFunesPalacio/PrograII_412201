﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Problema2_7_412201_IngIndirecta.Models;

public partial class DetalleTurnos
{
    public int IdDetalle { get; set; }

    public int IdTurno { get; set; }

    public int IdServicio { get; set; }

    public string Observaciones { get; set; }

    public virtual Servicios IdServicioNavigation { get; set; }

    public virtual Turnos IdTurnoNavigation { get; set; }
}