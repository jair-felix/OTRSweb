namespace OTRSweb.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
