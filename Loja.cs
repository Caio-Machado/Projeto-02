using System;
using System.Collections.Generic;

class Loja {
  //IDEIA PARA A LOJA
  /*LOJA DE ARTIGOS EM GERAL.
  Na minha ideia teriamos um catálogo dividído em 4 categorias
  cada uma com 10 itens totalizando 40 itens, eu colocaria a cada 10
  itens na lista seria uma categoria diferente ou seja do item 0 até o item 9 seria a sessão de eletrônicos (exemplo) e daí por diante
  continua com as outras categorias.*/

  /*
    Indices[0, 9] = Categoria Eletrônicos
    Indices[10, 19] = Artigos para o lar
    Indices[20, 29] = Ferramentas
    Indices[30, 39] = Brinquedos
  */
  //Listas
  List<string> nomesProdutos = new List<string>{"xiaomi", "Samsung J2 Core", "Carregador","Asus", "Smart tv 32p", "Smart Tv 50p", "Smartwatch Xiaomi", "Monitor LG 25p", "Home Theater Fama","Fone Xiaomi Piston 3",
  
  
  
  "Ar Condicionado","chuveiro", "Armário de cozinha", "Sofá", "Ventilador de Teto", "Geladeira", "Fogão 5 bocas", "Mesa 4 cadeiras", "Cama de casal" , "Painel Para Televisão",
  
  
  
  "Alicate bico 6 pvc Mayle", "Escada portátil 3 Degraus", "Caixa de ferramentas plástica", "Kit com 7 chaves de fenda", "Pá de jardinagem", "Furadeira a bateria", "Rastelo", "Enxada", "Martelo", "Serrote",

  
  
  "Uno", "xadrez", "Carrinho 4x4 Rock", "Barbie", "Sinuca Infantil", "Violão Infantil","Amoéba", "Pula Pirata",  "Lava Rápido HotWheels", "Quebra-Cabeça 1500 peças"}; //Nomes

  List<double> precosProdutos = new List<double>{"1199.90", "599.95", "39.95", "2999.90", "1250.90", "2199.99", "180.95", "949.90", "599.90", "49.90",
  

  
  "1339", "105", "1499.99", "626.39", "156.30", "1907.49", "1304.10", "981 ", "998.91", "664.10",
  
  
  
  "29.90", "89.90", "79.90", "25.90", "6.90", "269.90", "18.90", "24.90", "27.90", "34.90",
  
  
  
  "10,90", "20.40", "259,90", "37.90", "79.90", "29,90", "9.99", "69.95", "199.99", "49.90"}; //valores

  List<int> quantProdutos = new List<int>{5, 5, 10, 3, 5, 3, 8, 5, 8, 10,


  3, 7, 4, 6, 7, 4, 4, 8, 8, 5,


  10, 10, 5, 10, 10, 7, 10, 7, 7, 10, 10,

    
  10, 10, 5, 7, 5, 10, 10, 8, 4, 6};//Quantidades
  
  public List<string> getProdutos () {
    return nomesProdutos;
  }

  public List<double> getPrecos () {
    return precosProdutos;
  }

  public List<int> getQuantidades () {
    return quantProdutos;
  }
}