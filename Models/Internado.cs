using System.ComponentModel.DataAnnotations;

namespace ApiInternados.Models
{
    public class Internado
    {
        [Key]
        public int IdInternado { get; set; }
        public string? NumeroHC { get; set; }

        public int? IdPacientes { get; set; } 
        public int? IdInstitucion { get; set;}
        public int? IdPacTitular { get; set; }
        public string? CodInternacion { get; set; }
        public string? CodInternacionExt { get; set; }
        public string? CodAutorizacion { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public string? HoraIngreso { get;set; }
        public DateTime? FechaAlta { get; set; }
        public string? HoraAlta { get; set; }
        public int? IdTipoAlta { get; set; }
        public int? IdPrestador { get; set; }
        public string? DescDiagnostico { get; set; }
        public string? TrabajoPaciente { get; set; }
        public string? TelefonoTrabajoPaciente { get; set; }
        public string? DocGarante { get; set; }
        public string? NombreGarante { get; set; }
        public string? ApellidoGarante { get; set; }
        public DateTime? FechaNacGarante { get; set; }
        public string? DomicilioGarante { get; set; }
        public string? TelefonoGarante { get; set; }
        public string? TrabajoGarante { get; set; }
        public string? TelefonoTrabajoGarante { get; set; }
        public bool? Anulado { get; set; }
        public int? OpCrea { get; set; }
        public DateTime? FecCrea { get; set; }
        public int? OpEdita { get; set; }
        public DateTime? FecEdita { get; set; }
        public int? OpAnula { get; set; }
        public DateTime? FecAnula { get; set; }
        public int? diagn_ingreso_df { get; set; }
        public int? diagn_egreso_df { get; set; }
        public int? epicrisis_df { get; set; }
        public int? InternadoIDOriginal { get; set; }
        public string? LinkUbicacion { get; set; }























    }
}
