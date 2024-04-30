//ex 5 locadora
public class Filme{
    public string Titulo{get;set;}
    public string Genero{get;set;}
    public int Duracao{get;set;}
    public bool Disponivel{get;set;}

    public Filme(string titulo, string genero, int duracao){
        Titulo = titulo;
        Genero = genero;
        Duracao = duracao;
        Disponivel = true;
    }

    public void ExibeInfo(){
        Console.WriteLine($"Titulo: {Titulo} - Genero: {Genero} - Duração: {Duracao}");
    }
    public bool RegistrarLocacao(){
        return Disponivel = false;
    }

    public bool RegistrarDevolucao(){
        return Disponivel = true;
    }

    public void VerificaDisponibilidade(){
        Console.WriteLine("Disponivel? " + Disponivel);
    }

}