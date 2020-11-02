using System;
using System.Collections.Generic;
using System.Linq;
/*O Código acabou ficando com muitas linhas,
em sua maior parte por conta de funcionalidade de estética,
as regiões mais importantes que abrangem o escopo vão estar comentadas.*/

class MainClass {
  public static void Main (string[] args) {

    //Instanciando
    Cliente formulario = new Cliente("teste", "teste2", "teste3", 0, "N", 0);
    Carrinho adicionaCarrinho = new Carrinho(0, "teste", 0, 0);

    //Listas Criadas
    List<Cliente> clienteInfos = new List<Cliente>{};
    List<Carrinho> carDeCompras = new List<Carrinho>{};
    Loja executaCodigos = new Loja{};

    //-------------------
    //Atributos diversos
    //-------------------

    //Usados na Área do carrinho.
    //Linhas 451 até 535.
    string escreveProdutos; //Comportar o que será escrito na região da tabela.
    int adicionaQuantItem; //Comporta a resposta do usuário a respeito da quantidade que será adicionado ao estoque.
    int posicaoItemCar; //Resposta do usuário em relação a posição do item escolhido no carrinho.
    int respostaCarrinho; //Resposta do usuário sobre qual ação irá ser feita dentro do carrinho.

    //Usado para saber se o registro foi ou não realizado.
    bool registro = false;

    //Usado na Área do saldo.
    //Linhas 393 até 427.
    int respostaSaldo;

    //Usados na Área das compras.
    //Linhas 135 até 412
    int pedidoQuantidade; //Armazena a resposta do usuário em relação a quantidade do produto a ser adicionado ao carrinho.
    int respostaDepartamentosSair; //Armazena a opção a ser escolhida pelo usuário para ou selecionar um item do estoque ou escolher sair do estoque.

    // Pergunta da pergunta de qual área será iniciada.
    // Linhas 105...
    int respostaOpcoes;

    //-------------------------------------
    //Sentinelas Usadas em diversos whiles.
    //-------------------------------------

    // Sentinela do while que comporta todo o programa.
    //Linha 49.
    bool sentinelaGeral = true;
    // Sentinela do while da Área onde as comprars são realizadas
    //Linha 107 até 401.
    bool sentinelaComprar = true; // 107
    bool sentinelaEscolhendo = true; // 124
    // Sentinela para a área de vizualização e adição de saldo.
    //Linhas 414 até 444.
    bool sentinelaSaldo = true;

    //--------------------------------------

    //Console.WriteLine(executaCodigos.getCodigo()[25]);

    //While de inicio geral do sistema
    while (sentinelaGeral == true) {
      
      //Confirmação para saber se o registro ja foi realizado
      if (registro == false) {
        //Console.Clear();
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

        //Salvando as informações registradas.
        formulario = new Cliente(nome, endereco, cpf, idade, sexo, saldo);
        clienteInfos.Add(formulario);
        Console.Clear();

        //Dando um feedback do que foi salvo.
        Console.WriteLine("Dados Salvos:");
        Console.WriteLine($"Nome: {clienteInfos[0].getNome()}");
        Console.WriteLine($"Endereço: {clienteInfos[0].getEndereco()}");
        Console.WriteLine($"CPF: {clienteInfos[0].getCpf()}");
        Console.WriteLine($"Idade: {clienteInfos[0].getIdade()}");
        Console.WriteLine($"Sexo: {clienteInfos[0].getSexo()}");
        Console.WriteLine($"Saldo: {clienteInfos[0].getSaldo()}");
      
        Console.Write("Aperte Enter para continuar...");
        Console.ReadLine();
        Console.Clear();
        //Dizendo que o registro ja foi feito.
        registro = true;
      }

      else {
        /*Iniciando com as opções principais
        1 - Comprar - Abre opções de categorais para abrir o estoque com aqueles itens.
        
        2 - Uma maneira de adicionar dinheiro em uma carteira virtual da loja.
        
        3 - Ir até o carrinho de compras.*/
        Console.WriteLine("Escolha uma das opções abaixo \n 1 - Comprar\n 2 - vizualizar/Adicionar saldo \n 3 - Carrinho \n");
        
        respostaOpcoes = int.Parse(Console.ReadLine());
        Console.Clear();
        
        //Condicional caso ele queira ir até a área de compras
        if (respostaOpcoes == 1) {
          sentinelaComprar = true;
          sentinelaEscolhendo = true;
        
          while (sentinelaComprar == true) {
            //Regiaão de seleção de categoria de estoque. Todas as categorias possuem 10 itens de quantidades e preços variáveis.
            if (respostaOpcoes == 1) {
              Console.WriteLine("Qual departamento deseja acessar?");
              Console.WriteLine("1 - Eletrônicos em Geral \n2 - Artigos para a casa \n3 - Ferramentas \n4 - Brinquedos \n5 - voltar");


              if (respostaOpcoes == 5) {
                sentinelaComprar = false;
                sentinelaComprar = true;
              }

              else if (respostaOpcoes > 0 && respostaOpcoes < 5) {
                sentinelaEscolhendo = true;
                
                int respostaDerpatamentos = int.Parse(Console.ReadLine());
                Console.Clear();

                while (sentinelaEscolhendo == true) {

                  switch (respostaDerpatamentos) {
                  
                  //Categoria Eletrônicos
                  case 1: 
                    executaCodigos.mostraEstoque("Eletrônicos", 0, 10);
                    Console.WriteLine("\nPara escolher um produto digite o seu respectivo Código.");
                    Console.WriteLine("Caso deseje trocar de departamento digite 100.");
                    Console.WriteLine("Caso deseje para de comprar digite 101.");
                    Console.Write(">>");
                    respostaDepartamentosSair = int.Parse(Console.ReadLine());

                    //Caso o usuário escolha algum número que tenha relação com o código de um produto ele será selecionado. 
                    if (respostaDepartamentosSair > -1 && respostaDepartamentosSair < 10) {
                      //Caso o intem ja esteja no carrinho só poderá aumentar sua quantidade através do carrinho.
                      for (int cc=0; cc < carDeCompras.Count; cc++) {
                        if (respostaDepartamentosSair == carDeCompras[cc].getcodigoDoProduto()) {
                          respostaDepartamentosSair = -1;
                        }
                      }

                      //Caso não esteja dentro do carrinho o processo de escolha continua normalmente.
                      if (respostaDepartamentosSair != -1) {
                        Console.Write("Digite a quantidade desejada >> ");
                        pedidoQuantidade = int.Parse(Console.ReadLine());
                        
                        //Verificação que impede a escolha de uma quantidade maior que a existente no estoque.
                        if (pedidoQuantidade > executaCodigos.getQuantidades()[respostaDepartamentosSair]) {
                          Console.WriteLine("Quantidade Indisponível!");

                          Console.Write("Aperte Enter para continuar...");
                          Console.ReadLine();
                          Console.Clear();
                        }

                        else {
                          adicionaCarrinho = new Carrinho(respostaDepartamentosSair, executaCodigos.getProdutos()[respostaDepartamentosSair], pedidoQuantidade, executaCodigos.getPrecos()[respostaDepartamentosSair]);

                          carDeCompras.Add(adicionaCarrinho);

                          Console.Clear();
                        }
                      }
                    }

                    //Menssagem que avisa que o item ja está no carrinho.
                    else if (respostaDepartamentosSair == -1) {
                      Console.WriteLine("Item ja está no seu Carrinho!");
                      Console.Write("Aperte Enter para continuar...");
                      Console.ReadLine();
                      Console.Clear();
                    }

                    //Resposta caso ele queira trocar de categoria
                    else if (respostaDepartamentosSair == 100) {
                      /*for (int g=0; g < carDeCompras.Count; g++) {
                        Console.WriteLine(carDeCompras[g].getnomeDoProduto());
                      }*/
                      sentinelaEscolhendo = false;
                      Console.Clear();
                    }

                    //Resposta caso ele queira sair da área de compra.
                    else if (respostaDepartamentosSair == 101) {
                      sentinelaEscolhendo = false;
                      sentinelaComprar = false;
                      Console.Clear();
                    }

                    else {
                      Console.WriteLine("Valor digitado inválido.");

                      Console.Write("Aperte Enter para continuar...");
                      Console.ReadLine();
                      Console.Clear();
                    }
                    break;

                  //Categoria Artigos para a casa
                  case 2:
                    executaCodigos.mostraEstoque("Artigos para a casa", 10, 20);

                    Console.WriteLine("\nPara escolher um produto digite o seu respectivo Código.");
                    Console.WriteLine("Caso deseje trocar de departamento digite 100.");
                    Console.WriteLine("Caso deseje para de comprar digite 101.");
                    Console.Write(">>");
                    respostaDepartamentosSair = int.Parse(Console.ReadLine());

                    if (respostaDepartamentosSair > 9 && respostaDepartamentosSair < 20) {

                      for (int cc=0; cc < carDeCompras.Count; cc++) {
                        if (respostaDepartamentosSair == carDeCompras[cc].getcodigoDoProduto()) {
                          respostaDepartamentosSair = -1;
                        }
                      }

                      if (respostaDepartamentosSair != -1) {
                        Console.Write("Digite a quantidade desejada >> ");
                        pedidoQuantidade = int.Parse(Console.ReadLine());

                        if (pedidoQuantidade > executaCodigos.getQuantidades()[respostaDepartamentosSair]) {
                          Console.WriteLine("Quantidade Indisponível!");

                          Console.Write("Aperte Enter para continuar...");
                          Console.ReadLine();
                          Console.Clear();
                        }

                        else {
                          adicionaCarrinho = new Carrinho(respostaDepartamentosSair, executaCodigos.getProdutos()[respostaDepartamentosSair], pedidoQuantidade, executaCodigos.getPrecos()[respostaDepartamentosSair]);

                          carDeCompras.Add(adicionaCarrinho);

                          Console.Clear();
                        }
                      }
                    }

                    else if (respostaDepartamentosSair == 100) {
                      sentinelaEscolhendo = false;
                      Console.Clear();
                    }

                    else if (respostaDepartamentosSair == 101) {
                      sentinelaEscolhendo = false;
                      sentinelaComprar = false;
                      Console.Clear();
                    }

                    else if (respostaDepartamentosSair == -1) {
                      Console.WriteLine("Item ja está no seu Carrinho!");
                      Console.Write("Aperte Enter para continuar...");
                      Console.ReadLine();
                      Console.Clear();
                    }

                    else {
                      Console.WriteLine("Valor digitado inválido.");

                      Console.Write("Aperte Enter para continuar...");
                      Console.ReadLine();
                      Console.Clear();
                    }
                    break;

                  //Categoria Ferramentas
                  case 3:
                    executaCodigos.mostraEstoque("Ferramentas", 20, 30);
                    Console.WriteLine("\nPara escolher um produto digite o seu respectivo Código.");
                    Console.WriteLine("Caso deseje trocar de departamento digite 100.");
                    Console.WriteLine("Caso deseje para de comprar digite 101.");
                    Console.Write(">> ");
                    respostaDepartamentosSair = int.Parse(Console.ReadLine());

                    if (respostaDepartamentosSair > 19 && respostaDepartamentosSair < 29) {
                      for (int cc=0; cc < carDeCompras.Count; cc++) {
                        if (respostaDepartamentosSair == carDeCompras[cc].getcodigoDoProduto()) {
                          respostaDepartamentosSair = -1;
                        }
                      }

                      if (respostaDepartamentosSair != -1) {
                        Console.Write("Digite a quantidade desejada >> ");
                        pedidoQuantidade = int.Parse(Console.ReadLine());

                        if (pedidoQuantidade > executaCodigos.getQuantidades()[respostaDepartamentosSair]) {
                          Console.WriteLine("Quantidade Indisponível!");

                          Console.Write("Aperte Enter para continuar...");
                          Console.ReadLine();
                          Console.Clear();
                        }

                        else {
                          adicionaCarrinho = new Carrinho(respostaDepartamentosSair, executaCodigos.getProdutos()[respostaDepartamentosSair], pedidoQuantidade, executaCodigos.getPrecos()[respostaDepartamentosSair]);

                          carDeCompras.Add(adicionaCarrinho);

                          Console.Clear();
                        }
                      }
                    }

                    else if (respostaDepartamentosSair == -1) {
                      Console.WriteLine("Item ja está no seu Carrinho!");
                      Console.Write("Aperte Enter para continuar...");
                      Console.ReadLine();
                      Console.Clear();
                    }

                    else if (respostaDepartamentosSair == 100) {
                      sentinelaEscolhendo = false;

                      Console.Clear();
                    }

                    else if (respostaDepartamentosSair == 101) {
                      sentinelaEscolhendo = false;
                      sentinelaComprar = false;
                      Console.Clear();
                    }

                    else {
                      Console.WriteLine("Valor digitado inválido.");

                      Console.Write("Aperte Enter para continuar...");
                      Console.ReadLine();
                      Console.Clear();
                    }
                    break;
                  
                  //Categoria Brinquedos
                  case 4:
                    executaCodigos.mostraEstoque("Brinquedos", 30, 40);
                    Console.WriteLine("\nPara escolher um produto digite o seu respectivo Código.");
                    Console.WriteLine("Caso deseje trocar de departamento digite 100.");
                    Console.WriteLine("Caso deseje para de comprar digite 101.");
                    Console.Write(">>");
                    respostaDepartamentosSair = int.Parse(Console.ReadLine());

                    if (respostaDepartamentosSair > 29 && respostaDepartamentosSair < 40) {
                      for (int cc=0; cc < carDeCompras.Count; cc++) {
                        if (respostaDepartamentosSair == carDeCompras[cc].getcodigoDoProduto()) {
                          respostaDepartamentosSair = -1;
                        }
                      }

                      if (respostaDepartamentosSair != -1) {
                        Console.Write("Digite a quantidade desejada >> ");
                        pedidoQuantidade = int.Parse(Console.ReadLine());

                        if (pedidoQuantidade > executaCodigos.getQuantidades()[respostaDepartamentosSair]) {
                          Console.WriteLine("Quantidade Indisponível!");

                          Console.Write("Aperte Enter para continuar...");
                          Console.ReadLine();
                          Console.Clear();
                        }

                        else {
                          adicionaCarrinho = new Carrinho(respostaDepartamentosSair, executaCodigos.getProdutos()[respostaDepartamentosSair], pedidoQuantidade, executaCodigos.getPrecos()[respostaDepartamentosSair]);

                          carDeCompras.Add(adicionaCarrinho);

                          Console.Clear();
                        }
                      }
                    }

                    else if (respostaDepartamentosSair == -1) {
                      Console.WriteLine("Item ja está no seu Carrinho!");
                      Console.Write("Aperte Enter para continuar...");
                      Console.ReadLine();
                      Console.Clear();
                    }
              
                    else if (respostaDepartamentosSair == 100) {
                      /*for (int g=0; g < carDeCompras.Count; g++) {
                        Console.WriteLine(carDeCompras[g].getnomeDoProduto());
                      }*/
                      sentinelaEscolhendo = false;
                      Console.Clear();
                    }

                    else if (respostaDepartamentosSair == 101) {
                      sentinelaEscolhendo = false;
                      sentinelaComprar = false;
                      Console.Clear();
                    }

                    else {
                      Console.WriteLine("Valor digitado inválido.");

                      Console.Write("Aperte Enter para continuar...");
                      Console.ReadLine();
                      Console.Clear();
                    }
                    break;
                  }
                }
              }

              else {
                Console.WriteLine("Valor digitado é inválido");
              }
            }
          }
        }

        else if (respostaOpcoes == 2) {
          Console.Clear();

          while (sentinelaSaldo == true) {

            Console.WriteLine($"Seu saldo atual é {formulario.getSaldo()}");
            Console.WriteLine("Para adicionar saldo digite 1");
            Console.WriteLine("Para voltar digite 2");
            Console.Write(">>");
            respostaSaldo = int.Parse(Console.ReadLine());

            if (respostaSaldo == 1) {
              Console.Write("Digite o valor a ser adicionado >> ");
              formulario.setSaldo(double.Parse(Console.ReadLine()));
              Console.Clear();

              Console.WriteLine("Saldo adicionado com sucesso!!!");
              Console.WriteLine($"Seu saldo atual é {formulario.getSaldo()}\n");

              Console.Write("Aperte Enter para continuar...");
              Console.ReadLine();
              Console.Clear();
              //sentinelaSaldo = false;
            }

            else if (respostaSaldo == 2) {
              Console.Clear();
              sentinelaSaldo = false;
            }

            else {
              Console.WriteLine("Valor digitado é inválido!");
            }
          }
        }

        //Caso o usuário escolha vizualizar o carrinho
        //Ele utiliza a mesma estrutura do estoque só que modificado para se adaptar.
        else if (respostaOpcoes == 3) {

          //Lógica que organiza o estoque. (APENAS ESTÉTICO)
          if (carDeCompras.Any()) {
            Console.WriteLine(@"                    -------------------------------");
            Console.WriteLine($@"                              Carrinho ");
            Console.WriteLine(@"                    -------------------------------");

            Console.WriteLine("|   Código   |     Nome do Produto      |   Quantidade   |   Preço   |");
            Console.WriteLine("----------------------------------------------------------------------");

            for (int y=0; y < carDeCompras.Count ; y++) {
              //Ideias/Atributos
              escreveProdutos = $"  {carDeCompras[y].getnomeDoProduto()}";

              //Condicional para os códigos
              if (carDeCompras[y].getcodigoDoProduto() > -1 && carDeCompras[y].getcodigoDoProduto() < 10) {
                Console.Write($"|     {carDeCompras[y].getcodigoDoProduto()}      |");
              }

              else {
                Console.Write($"|     {carDeCompras[y].getcodigoDoProduto()}     |");
              }
          
          
              //Condicional para os nomes
              if (carDeCompras[y].getnomeDoProduto().Length < 24) {
            
                for (int w=0; w < (24 - carDeCompras[y].getnomeDoProduto().Length); w++) {
                  escreveProdutos = escreveProdutos + " ";
                }
                Console.Write(escreveProdutos + "|");
              }

              else {
                Console.Write(escreveProdutos + "|");
              }

              //Condicional para Quantidades
              if (carDeCompras[y].getquantidadeDoproduto() < 10) {
                Console.Write($"       {carDeCompras[y].getquantidadeDoproduto()}        |");
              }

              else {
                Console.Write($"       {carDeCompras[y].getquantidadeDoproduto()}       |");
              }

              Console.Write($"   {carDeCompras[y].getvalorTotalDoProduto()}\n");
              Console.WriteLine("----------------------------------------------------------------------");
            }

            /*Opções de coisas a se fazer no carrinho de compras:
            1 - Retirar um item, é possível excluir qualquer item do carrinho não importando sua quantidade.
            
            2 - Adicionar à quantidade atual de um produto, é possível aumentar a quantidade de um produto específico.
            
            3 - Retirar à quantidade atual de um produto, é possível diminuir a quantidade de um produto específico.
            
            4 - Finalizar compra é quando o carrinho será fechado e a compra realizada.*/
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine(
              @"1 - Retirar um item
2 - Adicionar à quantidade atual de um produto
3 - Retirar à quantidade atual de um produto
4 - Finalizar compra"
              );
            Console.Write(">> ");
            
            respostaCarrinho = int.Parse(Console.ReadLine());

            if (respostaCarrinho == 1) {
              Console.Write("\nDigite a posição do produto na lista acima: ");
              posicaoItemCar = int.Parse(Console.ReadLine());

              carDeCompras.RemoveAt(posicaoItemCar - 1);
            }

            else if (respostaCarrinho == 2) {
              Console.Write("\nDigite a posição do produto na lista acima: ");
              posicaoItemCar = int.Parse(Console.ReadLine()) - 1;
              Console.Write("\nDigite a quantidade a ser adicionada: ");
              adicionaQuantItem = int.Parse(Console.ReadLine());

              if (6 < 5); {

                Console.WriteLine(adicionaQuantItem + carDeCompras[posicaoItemCar].getquantidadeDoproduto());
                Console.WriteLine(carDeCompras[posicaoItemCar].getquantidadeDoproduto());
                Console.WriteLine(executaCodigos.getQuantidades()[carDeCompras[posicaoItemCar].getcodigoDoProduto()]);
                
                carDeCompras[posicaoItemCar].setquantidadeDoproduto(adicionaQuantItem + carDeCompras[posicaoItemCar].getquantidadeDoproduto());
              
                carDeCompras[posicaoItemCar].setvalorTotalDoProduto(executaCodigos.getPrecos()[carDeCompras[posicaoItemCar].getcodigoDoProduto()] * carDeCompras[posicaoItemCar].getquantidadeDoproduto());
              }

              /*else {
                Console.WriteLine("Quantidade Indisponível.");
                Console.Write("Aperte Enter para continuar...");
                Console.ReadLine();
                Console.Clear();
              }*/
            }

            else if (respostaCarrinho == 3) {
              Console.Write("\nDigite a posição do produto na lista acima: ");
              posicaoItemCar = int.Parse(Console.ReadLine()) - 1;
              Console.Write("\nDigite a quantidade a ser diminuida: ");
              adicionaQuantItem = int.Parse(Console.ReadLine());

              if (carDeCompras[posicaoItemCar].getquantidadeDoproduto() > 0) {
                
                carDeCompras[posicaoItemCar].setquantidadeDoproduto(carDeCompras[posicaoItemCar].getquantidadeDoproduto() - adicionaQuantItem);

                carDeCompras[posicaoItemCar].setvalorTotalDoProduto(executaCodigos.getPrecos()[carDeCompras[posicaoItemCar].getcodigoDoProduto()] * carDeCompras[posicaoItemCar].getquantidadeDoproduto());

                if (carDeCompras[posicaoItemCar].getquantidadeDoproduto() <= 0) {
                  carDeCompras.RemoveAt(posicaoItemCar);
                }
              } 
            }
          }

          else {
            Console.WriteLine("Seu carrinho ainda está vazio!");
            Console.Write("Aperte Enter para continuar...");
            Console.ReadLine();
            Console.Clear();
          
          }
        }
      }
    }
  }
}
