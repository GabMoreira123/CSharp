public class Personagem{
    private String nome;
    private int idade;
    private string poder;
    //Construtor de classe Personagem
    public Personagem(String nome , int idade, string poder){
        Nome = nome;
        Idade = idade;
        Poder = poder;
    }
     //Propriedade da classe Personagem que permite acesso controlado
 public string Nome{
    get{ return nome;}
    set{ nome = value;}
 }
 public decimal idade{ 
    get{return idade;}
    set{ idade = value;}
 }
 public string Poder{
    get { return poder;}
    set{poder = value;}
 }
}
public class Nativo : Personagem{
    private string Camuflagem;
    //Construtor da classe Nativo
    public Nativo (string nome, int idade, string poder):base(nome, idade, poder){
        Camuflagem = camuflagem;
    }
    //Propriedade da classe Nativo que permite acesso controlado a um campo privado
    public string Camuflagem{
        get{ return camuflagem;}
        set{ camuflagem = value;}
    }
}
public class Feiticeira : Personagem{
    private string feiticos;
    //Construtor da classe Feiticera  
    public Feiticeira (string nome, int idade, string poder):base(nome, idade, poder){
        Feiticos = feiticos;
    }
    //Propriedade da Feiticera que permite acesso controlado a um campo privado
    public string feiticos{
        get{ return feiticos;}
        set{  feiticos = feiticos;}
    }
}
public class Dragao : Personagem{
    private string baforada;
    //Construtor da classe Dragao  
    public Acessorio(string nome, int idade, string poder):base(nome, idade, poder){
        Baforada = baforada;
    }
    //Propriedade Dragao que permite acesso controlado a um campo privado
    public string baforada{
        get{ return baforada;}
        set{  baforada = value;}
    }
}

public class Program{

    public static void main (String [] args){

        Personagem personagem;
        Nativo nativo= new Nativo("Nativo", 26, "O Nativo tem a habilidade de camuflagem");
        nativo.Atacar();
        nativo.Atacar(Camuflagem e atauqe com dardos);
        Feiticeira feiticeira = new Feiticeira("Fewiticeira", 299, "A Feiticeira lança freiticos");
        feiticeira.Atacar();
        feiticeira.Atacar( lança feiticos para atordoar);
        Dragao dragao = new Dragao ("Dragao", 799, " O Dragao tem como ataque a baforada");
        dragao.Atacar();
        dragao.Atacar( Dispersa uma baforada de chamas);
        
   
    } -5
}

public class Personagem{
    public void Atacar(){
        ConsoleWrite.Line("Ataque Básico!");
    }
    public class Atacar(string habilidade){
        ConsoleWrite.Line("Ataque especial: + habilidade");
        
    }
}
public class Nativo : Personagem{
    public void Atacar(){
        ConsoleWrite.Line("Com a habilidade de Camuflagem!");
    }
}
public class Feiteceira : Personagem{
    public void Atacar(){
        ConsoleWrite.Line("lança feiticos para atacar!");
    }
}
public class Dragao : Personagem{
    public void Atacar(){
        ConsoleWrite.Line("Baforada de chamas!");
    }
}

