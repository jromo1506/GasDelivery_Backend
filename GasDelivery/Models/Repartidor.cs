using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GasDelivery.Models;

public partial class Repartidor
{
    [Key]
    public int Id { get; set; }

    public string Nombre { get; set; }

    public int Telefono { get; set; }

    public string UbicacionActual { get; set; }

    public string EstadoRepartidor { get; set; }

    public string ComentarioEstadoRepartidor { get; set; }

    public  ICollection<Pedido> Pedidos { get; set; }
}
