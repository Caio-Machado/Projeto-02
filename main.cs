using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {

    //Instanciando
    Cliente formulario = new Cliente("teste", "teste2", "teste3", 0, "N", 0);

    

    //Listas Criadas
    List<Cliente> clienteInfos = new List<Cliente>();
    List<Carrinho> carDeCompras = new List<Carrinho>();
    List<Loja> estoque = new List<Loja>();

    //Atributos
    char sentinela = 'S';
    bool registro = false;

    while (sentinela == 'S') {
      
      if (registro == false) {
        Console.WriteLine("-----------------------------");
        Console.WriteLine("Bem Vindo a Loja !!Tem de Tudo!!");
        Console.WriteLine("-----------------------------");

        Console.WriteLine("Primeiro é necessário realizar um cadastro, preencha o formulário abaixo com as devidas informações.");
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        
        Console.Write("Endereço: ");
        string endereco = Console.ReadLine();

        Console.Write("CPF: ");
        string cpf = Console.ReadLine();

        Console.Write("Idade: ");
        int idade = int.Parse(Console.ReadLine());

        Console.Write("Sexo: ");
        string sexo = Console.ReadLine();

        Console.Write("Saldo Inicial: ");
        double saldo = double.Parse(Console.ReadLine());

        formulario = new Cliente(nome, endereco, cpf, idade, sexo, saldo);
        clienteInfos.Add(formulario);
        Console.Clear();

        Console.WriteLine("Dados Salvos:");
        Console.WriteLine($"Nome: {clienteInfos[0].getNome()}");
        Console.WriteLine($"Endereço: {clienteInfos[0].getEndereco()}");
        Console.WriteLine($"CPF: {clienteInfos[0].getCpf()}");
        Console.WriteLine($"Idade: {clienteInfos[0].getIdade()}");
        Console.WriteLine($"Sexo: {clienteInfos[0].getSexo()}");
        Console.WriteLine($"Saldo: {clienteInfos[0].getSaldo()}");
      
        registro = true;
        Console.Write("Aperte Enter para continuar...");
        Console.ReadLine();
        Console.Clear();
      }

      else {
        Console.WriteLine("Escolha uma das opções abaixo \n 1 - Loja\n 2 - vizualizar/Adicionar saldo \n 3 - Carrinho \n");
        
        int resposta = Console.ReadLine();

        //if (resposta == 1) {
          
        //}
      }
    }
  }
}
