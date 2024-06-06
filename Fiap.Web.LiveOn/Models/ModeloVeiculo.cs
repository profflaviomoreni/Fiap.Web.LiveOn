namespace Fiap.Web.LiveOn.Models
{
    public class ModeloVeiculo
    {

        public int ModeloVeiculoId { get; set; }
        public string NomeModelo { get; set; }

        public int MontadoraId { get; set; }
        public Montadora Montadora { get; set; }
        public int AnoModelo { get; set; }
        public string TipoCombustivel { get; set; }


        public ModeloVeiculo()
        {
                
        }


        public ModeloVeiculo(int modeloVeiculoId, string nomeModelo, int anoModelo, string tipoCombustivel)
        {
            ModeloVeiculoId = modeloVeiculoId;
            NomeModelo = nomeModelo;
            AnoModelo = anoModelo;
            TipoCombustivel = tipoCombustivel;
        }

        public ModeloVeiculo(int modeloVeiculoId, string nomeModelo, Montadora montadora, int anoModelo, string tipoCombustivel)
        {
            ModeloVeiculoId = modeloVeiculoId;
            NomeModelo = nomeModelo;
            Montadora = montadora;
            AnoModelo = anoModelo;
            TipoCombustivel = tipoCombustivel;
        }
    }
}
