using System;
using System.Collections.Generic;

class Cliente {
  //Informações do Cliente.
  private string Nome, Endereco, Cpf, Sexo;
  private int Idade;
  private double Saldo;

  //GET's
  public string getNome () {
    return Nome;
  }

  public string getEndereco () {
    return Endereco;
  }

  public string getCpf () {
    return Cpf;
  }

  public int getIdade () {
    return Idade;
  }

  public string getSexo () {
    return Sexo;
  }

  public double getSaldo () {
    return Saldo;
  }

  public void setSaldo (double s) {
    Saldo = Saldo + s;
  }

  //Construtor de registro.
  public Cliente (string nome, string endereco, string cpf, int idade, string sexo, double saldo) {
    Nome = nome;
    Endereco = endereco;
    Cpf = cpf;
    Idade = idade;
    Sexo = sexo;
    Saldo = saldo;
  }
  
}