public class Produto{
    private String nome;
    private decimal preco;
    private string descricao;
    private string categoria;
    //Construtor de classe Produto
    public Produto(String nome , decimal preco, string descricao, string categoria){
        Nome = nome;
        Preco = preco;
        Descricao = descricao;
        Categoria = categoria;
    }
     //Propriedade da classe Produto que permite acesso controlado
 public string Nome{
    get{ return nome;}
    set{ nome = value;}
 }
 public decimal Preco{
    get{return preco;}
    set{ preco = value;}
 }
 public string Descricao{
    get { return descricao;}
    set{descricao = value;}
 }
  public string Categoria{
    get { return categoria;}
    set{categoria = value;}
 }
}
public class ConsoleGame : Produto{
    private int CapacidadeArmazenamento;
    //Construtor da classe ConsoleGame  
    public ConsoleGame (string nome, decimal preco, string descricao, string categoria):base(nome, preco, descricao, categoria){
        capacidadeArmazenamento = capacidadeArmazenamento;
    }
    //Propriedade da classe ConsoleGame que permite acesso controlado a um campo privado
    public string CapacidadeArmazenamento{
        get{ return capacidadeArmazenamento;}
        set{ capacidadeArmazenamento = value;}
    }
}
public class Jogo : Produto{
    private string genero;
    //Construtor da classe ConsoleGame  
    public Jogo (string nome, decimal preco, string descricao, string categoria):base(nome, preco, descricao, categoria){
        Genero = genero;
    }
    //Propriedade da classe ConsoleGame que permite acesso controlado a um campo privado
    public string genero{
        get{ return genero;}
        set{  genero = value;}
    }
}
public class Acessorio : Produto{
    private string genero;
    //Construtor da classe ConsoleGame  
    public Acessorio(string nome, decimal preco, string descricao, string categoria):base(nome, preco, descricao, categoria){
        Tipo = tipo;
    }
    //Propriedade da classe ConsoleGame que permite acesso controlado a um campo privado
    public string tipo{
        get{ return tipo;}
        set{  tipo = value;}
    }
}
public class Colecionavel : Produto{
    private bool edicaoLimitada;
    //Construtor da classe ConsoleGame  
    public Colecionavel (string nome, decimal preco, string descricao, string categoria, bool edicaoLimitada):base(nome, preco, descricao, categoria){
        EdicaoLimitada = edicaoLimitada;
    }
    //Propriedade da classe ConsoleGame que permite acesso controlado a um campo privado
    public string edicaoLimitada{
        get{ return edicaoLimitada;}
        set{  edicaoLimitada = value;}
    }
}
public class Program{

    public static void main (String [] args){

        Produto produto;
        produto = new ConsoleGame("PlayStation 5", 5.800, "Console de Vídeo Game PlayStation 5 Slim com 1 tera de armazenamento","Console", 1024000);
   
        Jogo jogo = new Jogo("Marvel's Spider-Man 2 Premium", 299.9, "Jogo Completo Marvel's Spider-Man 2 para PS5.","Jogo PS5", "Ação e Aventura");

        Acessorio acessorio = new acessorio ("Havit HV-H2232d", 79.9 , " Fone de ouvido Bluetooth áudio dois lados alta qualidade", "Fone de ouvido", "Acessorio");
        
        Colecionavel colecionavel = new colecionavel ("Super Mario Bros", 319.9 , " jogo para Console do Super Mario edicao limitada", "Jogo PS5", "Colecionavel");
   
   
   
    } 
}