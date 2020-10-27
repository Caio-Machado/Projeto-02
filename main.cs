using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {

    //Instanciando
    Cliente formulario = new Cliente("teste", "teste2", "teste3", "teste4", 0, 'N');

    }

    //Listas Criadas
    List<Cliente> clienteInfos = new List<Cliente>();
    List<Carrinho> carDeCompras = new List<Carrinho>();
    List<Loja> estoque = new List<Loja>();

    //Atributos
    char sentinela = 'S';

    while (sentinela == 'S') {
      Console.WriteLine("-----------------------------");
      Console.WriteLine("Bem Vindo a Loja !!Tem de Tudo!!");
      Console.WriteLine("-----------------------------");

      Console.WriteLine("Primeiro é necessário realizar um cadastro, preencha o formulário abaixo com as devidas informações.");
      Console.WriteLine("Nome:");
      nome = Console.ReadLine();
      
      Console.WriteLine("Endereço:");
      endereco = Console.readLine();

      Console.WriteLine("CPF");
      cpf = Console.ReadLine();

      Console.WriteLine("Idade:");
      idade = int.Parse(Console.ReadLine());

      Console.WriteLine("Sexo:");
      sexo = char.Parse(Console.ReadLine());

      Console.WriteLine("Saldo Inicial:");
      saldo = double.Parse(Console.ReadLine());

      formulario = new Cliente(nome, endereco, cpf, idade, sexo, saldo);
    }
  }
}
"Escolha uma das opções abaixo \n", "1 - Produtos\n" , "2 - vizualizar/Adicionar saldo \n", "3 - Carr"