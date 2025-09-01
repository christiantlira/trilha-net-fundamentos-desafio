using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoPorHora = 0;
decimal precoInicial = 0;

System.Console.WriteLine("Seja bem vindo ao SysGarage");

System.Console.WriteLine("Digite o preço inicial:");
precoInicial = Convert.ToDecimal(Console.ReadLine());

System.Console.WriteLine("Digite o preço por hora:");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

Estacionamento estacio = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

while(exibirMenu){
    Console.Clear();
    System.Console.WriteLine("Digite a sua opção:");
    System.Console.WriteLine("1 - Cadastrar veículo");
    System.Console.WriteLine("2 - Remover veículo");
    System.Console.WriteLine("3 - Listar veículo");
    System.Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            estacio.adicionarVeiculo();
            break;
        case "2":
            estacio.removerVeiculo();
            break;
        case "3":
            estacio.listarVeiculos();
            break;
        case "4":
            exibirMenu = false;
            break;
    }

    System.Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}
System.Console.WriteLine("O programa fechou!");