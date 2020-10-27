using System;
using System.Collections.Generic;

class Cliente {
  //Informações do Cliente.
  private string Nome, Endereco, Cpf;
  private int Idade;
  private char Sexo;
  private double Saldo;

  //GET's
  public string getNome () {
    return Nome;
  }

  public string getEndereco () {
    return Endereco;
  }

  public string getEmail () {
    return Email;
  }

  public string getCpf () {
    return Cpf;
  }

  public int getIdade () {
    return Idade;
  }

  public char getSexo () {
    return Sexo;
  }

  public double getSaldo () {
    return Saldo;
  }

  //Construtor de registro.
  public Cliente (string nome, string endereco, string email, string cpf, int idade, char sexo, double saldo) {
    Nome = nome;
    Endereco = endereco;
    Email = email;
    Cpf = cpf;
    Idade = idade;
    Sexo = sexo;
    Saldo = saldo;
  }
  
}