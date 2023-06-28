using System;
using System.Collections.Generic;

namespace WebApi.Models;

public partial class Horario
{
    public int IdHorarios { get; set; }

    public TimeSpan FechaI { get; set; }

    public TimeSpan FechaF { get; set; }

    public virtual ICollection<Citum> Cita { get; set; } = new List<Citum>();
}
