using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GasDelivery.Models;

public partial class InfoCliente
{
    [Key]
    public int Id { get; set; }
   
    public string Nombre { get; set; }

    public int Telefono { get; set; }
   
    public string Correo { get; set; }
  
    public string Calle { get; set; }
    
    public string Ciudad { get; set; }

    public string NoExterior { get; set; }

    public string NoInterior { get; set; }
  
    public string CruceCalles { get; set; }

    public Pedido Pedido { get; set; }

    public Suscripcion Suscripcion { get; set; }


    public int Id_InfoCliente { get; set; }
    public Usuario Usuarios { get; set; }
}
