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
            bool menuAnterior = true;
            do
            {
                Console.WriteLine("\nDigite a placa do veículo para estacionar ou tecle 0 para voltar ao menu anterior.");
                string placaEntrada = Console.ReadLine().Trim().ToUpper();
                if (placaEntrada != null & placaEntrada != "" & placaEntrada != "0")
                {
                    if (!(veiculos.Contains(placaEntrada)))
                    {
                        veiculos.Add(placaEntrada);
                        Console.WriteLine($"Entrada do veiculo de placa '{placaEntrada}' registrada com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Esse veículo já se encontra registrado no estacionamento.");
                    }
                }
                else if (placaEntrada == "0")
                {
                    menuAnterior = false;
                }
                else
                {
                    Console.WriteLine("\nDigite uma placa válida!");
                }
            }while(menuAnterior);           

        }

        public void RemoverVeiculo()
        {
            bool menuAnterior = true;
            do
            {
                Console.WriteLine("\nDigite a placa do veículo para remover ou 0 para voltar ao menu anterior:");
                string placaRemocao = Console.ReadLine().Trim().ToUpper();

                if (placaRemocao == "0")
                {
                    menuAnterior = false;
                }
                // Verifica se o veículo existe
                else {
                    if (veiculos.Any(x => x == placaRemocao))
                    {
                        // Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                        Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                        int horasEstacionado = Convert.ToInt32(Console.ReadLine());
                        decimal valorTotal = precoInicial + precoPorHora * horasEstacionado;

                        veiculos.Remove(placaRemocao);
                        Console.WriteLine($"O veículo de '{placaRemocao}' foi removido e o preço total foi de: R$ {valorTotal}");
                    }
                    else
                    {
                        Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente.");
                    }
                }                
            } while (menuAnterior);
        }

        public void ListarVeiculos()
        {

            bool menuAnterior = true;
            do
            {
                // Verifica se há veículos no estacionamento
                if (veiculos.Any())
                {
                    Console.WriteLine("\nOs veículos estacionados são:");
                    foreach (string todosVeiculos in veiculos)
                    {
                        Console.WriteLine(todosVeiculos);
                    }
                    Console.WriteLine("\nDigite qualquer tecla para voltar ao meno anterior.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Não há veículos estacionados.");
                    Console.WriteLine("\nDigite qualquer tecla para voltar ao meno anterior.");
                    Console.ReadLine();
                }
                menuAnterior = false;
            } while (menuAnterior);





        }
    }
}
