namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (Suite.Capacidade <= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("O número de hóspedes não pode ser maior que a capacidade da suíte.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            int quantidadeHospedes = Hospedes.Count;
            return quantidadeHospedes;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor;
            if (DiasReservados >= 10)
            {
                valor = (DiasReservados * Suite.ValorDiaria) - DiasReservados * Suite.ValorDiaria * 0.1M;
            }
            else
            {
                valor = DiasReservados * Suite.ValorDiaria;
            }

            return valor;
        }
    }
}