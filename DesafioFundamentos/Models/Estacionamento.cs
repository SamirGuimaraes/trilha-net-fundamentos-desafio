namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // IMPLEMENTADO
            List<string> veiculos = new List<string>();

            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            veiculos.Add(placa);
            
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // IMPLEMENTADO
            string placa = "";

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                // IMPLEMENTADO
                int horas = 0;
                decimal valorTotal = 0; 

                Console.WriteLine("Quantas horas o veículo permaneceu estacionado?");
                string input = Console.ReadLine();

                if (int.TryParse(input, out horas))
                {
                    valorTotal = precoPorHora * horas;
                    Console.WriteLine($"Valor total: R$ {valorTotal}");
                }
                else
                {
                    Console.WriteLine("Inserção de hora inválida. Certifique-se de inserir um número inteiro.");
                }

                // Remover a placa digitada da lista de veículos
                // IMPLEMENTADO

                veiculos.Remove(placa);
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // Realizar um laço de repetição, exibindo os veículos estacionados
                // IMPLEMENTADO
                foreach (var placa in veiculos)
                {
                    Console.WriteLine($"Placa: {placa}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
