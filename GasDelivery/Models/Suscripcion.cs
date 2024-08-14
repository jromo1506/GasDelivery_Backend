using System.ComponentModel.DataAnnotations;

namespace GasDelivery.Models
{
    public class Suscripcion
    {
        [Key]
        public int Id {  get; set; }
        public string Periodicidad { get; set; }
        public string Estado { get; set; }
        public string Tipo_servicio { get; set; }

        public DateTime Fecha_inicio { get; set; }
        public DateTime Fecha_fin { get; set; }

        
        //Propiedad de navegacion InfoCliente
        public InfoCliente InfoCliente { get; set; }

        //Llave foranea a InfoCliente

        public int Id_InfoCliente { get; set;}


    }
}
