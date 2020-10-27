using System;
using System.Collections.Generic;

class Cliente {
  //Informações do Cliente.
  private string Nome, Endereco, Email, Cpf;
  private int Idade;
  private char Sexo;

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

  //Construtor de registro.
  public Cliente (string nome, string endereco, string email, string cpf, int idade, char sexo) {
    Nome = nome;
    Endereco = endereco;
    Email = email;
    Cpf = cpf;
    Idade = idade;
    Sexo = sexo;
  }
  
}