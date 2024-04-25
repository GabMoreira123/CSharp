using System;

public abstract class Personagem
{
    // Atributos da classe personagem
    protected string nome;
    protected int vida;

    // Construtor da classe Personagem
    public Personagem(string nome, int vida)
    {
        this.nome = nome;
        this.vida = vida;
    }

    // Método abstrato para o ataque
    public abstract void Atacar();

    // Getters e setters para os atributos
    public string GetNome()
    {
        return nome;
    }

    public void SetNome(string nome)
    {
        this.nome = nome;
    }

    public int GetVida()
    {
        return vida;
    }

    public void SetVida(int vida)
    {
        this.vida = vida;
    }
}

public class Guardiao : Personagem
{
    public Guardiao(string nome, int vida) : base(nome, vida) { }

    public override void Atacar()
    {
        Console.WriteLine($"{nome} atacou com o seu cajado!");
    }

    public void AspectoFlamejante()
    {
        Console.WriteLine($"{nome} ataque que incendeia os inimigos!");
    }
}

public class Feiticeira : Personagem
{
    public Feiticeira(string nome, int vida) : base(nome, vida) { }

    public override void Atacar()
    {
        Console.WriteLine($"{nome} atacou com um feitiço com sua varinha mágica!");
    }

    public void Escudo()
    {
        Console.WriteLine($"{nome} criou uma barreira mágica para se defender!");
    }
}

public class Duende : Personagem
{
    public Duende(string nome, int vida) : base(nome, vida) { }

    public override void Atacar()
    {
        Console.WriteLine($"{nome} atacou com uma adaga!");
    }

    public void Esquiva()
    {
        Console.WriteLine($"{nome} se esquivou ágilmente para se defender!");
    }
}

public class Pokemon : Personagem
{
    public Pokemon(string nome, int vida) : base(nome, vida) { }

    public override void Atacar()
    {
        Console.WriteLine($"{nome} atacou com suas garras!");
    }

    public void Raio()
    {
        Console.WriteLine($"{nome} eletrizou sua pele para se defender!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Personagem guardiao = new Guardiao("Guardião", 1000);
        Personagem feiticeira = new Feiticeira("Feiticeira", 90);
        Personagem duende = new Duende("Duende", 110);
        Personagem pokemon = new Pokemon("Raichu", 170);

        guardiao.Atacar();
        ((Guardiao)guardiao).AspectoFlamejante(); // método específico de Guardião

        feiticeira.Atacar();        
        ((Feiticeira)feiticeira).Escudo(); // método específico de Feiticeira

        duende.Atacar();
        ((Duende)duende).Esquiva(); // método específico de Duende

        pokemon.Atacar();
        ((Pokemon)pokemon).Raio(); // método específico de Pokemon
    }
}
