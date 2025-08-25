using System.ComponentModel.DataAnnotations;

namespace LogicaDeNegocio
{
    public class EventoVM
    {
        [Display(Name = "Nombre de Evento")]
        public string NombreEvento { get; set; }
        public int IdEvento { get; set; }
        public DateTime FechaEvento { get; set; }

    }
}
