using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GasDelivery.Models;

public partial class Usuario
{
    [Key]
    public int Id { get; set; }

    public int NombreUsuario { get; set; }

    public int Contrasena { get; set; }

    public int Tipo { get; set; }

    public int Id_InfoCliente { get; set; }

    public  InfoCliente InfoCliente { get; set; }

    //Propiedad de navegacion a tarjeta

    public  ICollection<Tarjeta> Tarjetas { get; set; } 
}
