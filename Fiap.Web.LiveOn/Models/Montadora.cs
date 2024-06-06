namespace Fiap.Web.LiveOn.Models
{
    public class Montadora
    {

        public int MontadoraId { get; set; }
        public string Nome { get; set; }
        public string PaisOrigem { get; set; }
        public int AnoFundacao { get; set; }


        public Montadora()
        {
                
        }

        public Montadora(int montadoraId, string nome, string paisOrigem, int anoFundacao)
        {
            MontadoraId = montadoraId;
            Nome = nome;
            PaisOrigem = paisOrigem;
            AnoFundacao = anoFundacao;
        }
    }
}
