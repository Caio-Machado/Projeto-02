using System;
using System.Collections.Generic;

class Carrinho {
  //Atributos
  private int codigoDoProduto;
  private string nomeDoProduto;
  private int quantidadeDoproduto;
  private double valorTotalDoProduto;
  private double valorDoCarrinho;

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

  public void setquantidadeDoproduto (int qdp) {
    quantidadeDoproduto = qdp;
  }

  public double getvalorTotalDoProduto () {
    return valorTotalDoProduto;
  }

  public void setvalorTotalDoProduto (double vtdp) {
    valorTotalDoProduto = vtdp;
  }

  public void setvalorDoCarrinho (double vtdc) {
    valorDoCarrinho = vtdc;
  }

  public double getvalorDoCarrinho () {
    return valorDoCarrinho;
  }

  //Construtor
  public Carrinho (int CDP, string NDP, int QDP, double VTDP) {
    codigoDoProduto = CDP;
    nomeDoProduto = NDP;
    quantidadeDoproduto = QDP;
    valorTotalDoProduto = VTDP * QDP;
  }
}