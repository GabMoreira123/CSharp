public class Pessoa{
 private String nome;
 private int idade; private String cpf;
 //Construtoir de classe Pessoa
 public Pessoa(String nome, int idade, string cpf){
    Nome = nome;
    Idade = idade;
    CPF = cpf;
 }
 //Propriedade da classe Pessoa que permite acesso controlado
 public string Nome{
    get{ return nome;}
    set{ nome = value;}
 }
 public int Idade{
    get{return idade;}
    set{ idade = value;}
 }
 public string CPF{
    get { return cpf;}
    set{cpf = value;}
 }
}
public class Estudante : Pessoa{
    private String curso;
    //Construtor da classe Estudante 
    public Estudante(string nome, int idade, string cpf, string curso): base(nome,idade, cpf){
        Curso = curso;
    }
    //Propriedade da classe Estudante que permite acesso controlado aum campo privado
    public string Curso{
        get{ return curso;}
        set{ curso = value;}
    }
}
public class Funcionario: Pessoa{
   private double salario;

   //Método para calcular o bônus
   public double Bonus(){
      return salario *0.1;

   }
 public Funcionario(string nome, int idade, string cpf, double salario):base(nome,idade,cpf){
    Salario = salario;
 }

//Propriedades da classe estudante que permite acesso controlado a um campo privado
public string Salario{
   get{return salario;}
   set{salario = value;}
}
}