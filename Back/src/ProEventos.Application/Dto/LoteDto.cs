using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProEventos.Application.Dto
{
    public class LoteDto
    {
        public int Id { get; set; }
        //[Required] 
        //[NotMapped]
        //[MaxLength]
        //public int Teste { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public string DataInicio { get; set; }
        public string DataFim { get; set; }
        //[ForeignKey("Eventos")]
        public int teste { get; set; }
        public EventoDto Evento { get; set; }
    }
}