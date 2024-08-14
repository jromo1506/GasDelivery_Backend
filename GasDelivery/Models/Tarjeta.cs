using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GasDelivery.Models;

public partial class Tarjeta
{
    [Key]
    public int Id { get; set; }

    public int NumeroTarjeta { get; set; }

    public DateTime FechaVencimiento { get; set; }

    public DateTime Nip { get; set; }


    //Llave foranea
    public int Id_Usuario { get; set; }

    //Propiedad de navegacion a usuario

    public  Usuario Usuario { get; set; }
}
