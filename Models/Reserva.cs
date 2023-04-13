using DesafioProjetoHospedagem.Models;


namespace DesafioProjetoHospedagem.Models;

    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Reserva(Suite suite) 
        {
            this.Suite = suite;
   
        }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            int quantidade_hospedes = hospedes.Count;           
            // DONE: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            
            if (Suite.Capacidade>=quantidade_hospedes)
            {
                Console.WriteLine($"Suite Reservada !Bem-Vindos");
                Hospedes = hospedes;
            }
            else 
            {
                Console.WriteLine("Quantidade não permitida para reserva");            
              //DONE: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
            } 
            try
            {

            } catch(Exception ex)
            {
                Console.WriteLine($"Capacidade menor registrada.{ex.Message}");
            }
            
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // DONE: Retorna a quantidade de hóspedes (propriedade Hospedes)            
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            // DONE: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria            
            decimal valor = DiasReservados*Suite.ValorDiaria;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%

            if (DiasReservados>=10)
            {
                Console.WriteLine($"Cupon de Desconto Aplicado");
                valor = valor*90/100;
            }

            return valor;
        }
    }

