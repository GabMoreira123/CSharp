Using System;

class Carros{
 //Atributos
  private string nome;
  private string cor;
  private int idade;
  private double altura;
  private char genero;

  //Construtor
  public Carros(string nome, string cor, int idade, double altura, char genero){
    this.nome = nome; 
    this.cor =cor;
    this.idade = idade;
    this.altura = altura;
    this.genero = genero;
  }
 //Metodos
 public void infoCarros(){
  Console.WriteLine($"Nome:{nome}, idade: {idade}, altura:{altura}, genero:{genero}");
 
 }
 public void Nitro(){
  Console.WriteLine("Nitrando.");
 }
  public void Voar(){
    Console.WriteLine("Voando.");
  }

}
  public class Ferrari : Carros{
    public Ferrari (){
      this.nome = "Ferrari"
      this.cor = "Vermelho"
      this.idade = 2;
      this.altura = 1,40;
      this.genero = "M";

      public void Turbo(){
        Console.WriteLine("Ferrari ativou o turbo")
      }
    }
  }
   public class Lamborghini : Carros{
    public Lamborghini (){
      this.nome = "Lamborghini"
      this.cor = "Laranja"
      this.idade = 2;
      this.altura = 1,63;
      this.genero = "M";

      public void Stage(){
        Console.WriteLine("Lamborghini ativou o stage")
      }
    }
  }

  class Program{
    static void Main(string[]args){
      Ferrari ferrari = new Ferrari();
      Lamborghini lamborghini = new lamborghini();

Console.WriteLine($"Nome:{ferrari.Nome}, Cor:{ferrari.Cor},Idade:{ferrari.Idade},Altura:{ferrari.Altura}, Gênero:{ferrari,Genero}");

 ferrari.Nitro();
 ferrari.Voar();
 ferrari.Turbo();

 Console.WriteLine();
 Console.WriteLine($"Nome:{lamborghini.Nome}, Cor:{lamborghini.Cor}, Idade:{lamborghini.Idade}, Altura:{lamborghini.Altura}, Gênero:{lamborhini.Genero}");

 lamborghini.Nitro();
 lamborghini.Voar();
 lamborghini.Stage();

    }
  }
  
  

  