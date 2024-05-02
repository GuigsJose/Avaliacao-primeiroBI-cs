//ex10

public class Voo : IReserva{

    public string Data{get;set;}
    public string Origem{get;set;}
    public string Destino{get;set;}
    public string StatusVoo{get;set;}

    public Voo(string data, string origem, string destino){
        Data = data;
        Origem = origem;
        Destino = destino;
    }  

    public virtual void Reservar(){
        Console.WriteLine("Voo reservado para:" + Destino);
        StatusVoo = "Reservado";
    }
    public virtual void Cancelar(){
        Console.WriteLine("Reserva do voo para: " + Destino + " CANCELADO");
        StatusVoo = "Cancelado";
    }
    public virtual void Status(){
        Console.WriteLine("Voo");
        Console.WriteLine("Origem: " + Origem);
        Console.WriteLine("Destino: " + Destino);
        Console.WriteLine("Data: " + Data);
        Console.WriteLine("Status: " + StatusVoo);
    }
}