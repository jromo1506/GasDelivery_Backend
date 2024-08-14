using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GasDelivery.Models;

public partial class Pedido
{
    [Key]
    public int Id { get; set; }


    public string TipoServicio { get; set; }

    public DateTime HoraSalida { get; set; }

    public DateTime HoraLlegada { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal Costo { get; set; }

    public int TiempoEstimado { get; set; }

    public string EstadoPedido { get; set; }

    public string MetodoPago { get; set; }



    public int Id_Repartidor { get; set; }

    public int Id_InfoCliente { get; set; }


    
    public  InfoCliente InfoCliente { get; set; }



    public  Repartidor Repartidor { get; set; }
}
