using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        decimal precoInicial = 0;
        decimal precoPorHora = 0;
        List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora){
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void adicionarVeiculo(){
            System.Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            veiculos.Add(placa);
            System.Console.WriteLine("Veículo adicionado com sucesso!");
        }

        public void removerVeiculo(){
            System.Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                System.Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas = int.Parse(Console.ReadLine());
                decimal valorTotal = precoInicial + precoPorHora * horas;

                veiculos.Remove(placa);    
                Console.WriteLine($"O veículo {placa} foi removido e o preço total a se pagar é de: R${valorTotal}");
            } else {
                System.Console.WriteLine("Esse veículo não está estacionado aqui. Você estacionou em outro lugar!");
            }
        }

        public void listarVeiculos(){
            if(veiculos.Any()){
                System.Console.WriteLine("Os carros estacionados aqui são:");
                foreach (string carro in veiculos)
                {
                    System.Console.WriteLine(carro);

                }
            } else {
                System.Console.WriteLine("Não há veículos estacionados aqui.");
            }

        }
    }
}