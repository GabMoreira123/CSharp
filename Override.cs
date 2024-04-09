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
   
        Feiticeira feiticeira = new Feiticeira("Fewiticeira", 299, "A Feiticeira lança freiticos");

        Dragao dragao = new Dragao ("Dragao", 799, " O Dragao tem como ataque a baforada");
        
   
    } -5
}
public class Personagem {
    public virtual void Atacar(){
        Console.WriteLine("Ataque primário")
    }
}

public class Nativo: Personagem{
    public override void Atacar(){
        Console.WriteLine("Nativo ataca com a lança!")
    }
}

public class Feiticeira: Personagem{
    public override void Atacar(){
        Console.WriteLine("Feiticeira ataca com feitico!")
    }
}

public class Dragao: Personagem{
    public override void Atacar(){
        Console.WriteLine("Dragao ataca com a baforada!")
    }
}
}
