using System;
using System.Collections.Generic;

class Carrinho {
  //Atributos
  private int codigoDoProduto;
  private string nomeDoProduto;
  private int quantidadeDoproduto;
  private double valorTotalDoProduto, valorDoCarrinho;

  //GET's
  public int getcodigoDoProduto () {
    return codigoDoProduto;
  }

  public string getnomeDoProduto () {
    return nomeDoProduto;
  }

  public int getquantidadeDoproduto () {
    return quantidadeDoproduto;
  }

  public double getvalorTotalDoProduto () {
    return valorTotalDoProduto;
  }

  public double getvalorDoCarrinho () {
    return valorDoCarrinho;
  }

  //Construtor
  public Carrinho (int CDP, string NDP, int QDP, double VTDP, double VDC) {
    codigoDoProduto = CDP;
    nomeDoProduto = NDP;
    quantidadeDoproduto = QDP;
    valorTotalDoProduto = VTDP;
    valorDoCarrinho = VDC;
  }
  
}