
class Musica
{
    public Musica(Banda artista, string nome) //CONSTRUTOR
    {
        Artista = artista;
        Nome = nome;
    }
  public string Nome { get; }
  public Banda Artista { get; }
  public int Duracao { get; set; }
  public bool Disponivel { get; set; }

  public string DescricaoResumida =>
    $"A música {Nome} perntence à banda {Artista}";

  public void ExibirFichaTecnica()
  {
    Console.WriteLine($"Música: {Nome}");
    Console.WriteLine($"Artista: {Artista.Nome}");
    Console.WriteLine($"Duração: {Duracao}");
    if (Disponivel)
    {
      Console.WriteLine("Disponivel");
    }
    else
    {
      Console.WriteLine("Adquira o plano plus");
    }
  }
}