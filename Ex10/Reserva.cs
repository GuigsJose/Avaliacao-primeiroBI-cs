public class Reserva : IReserva{
    public string classe = "regular";
    public bool Reservado{get;set;}

    public string Data{get;set;}
    public string Origem{get;set;}
    public string Destino{get;set;}

    public Reserva(string data,string origem, string destino){
        Data = data;
        Origem = origem;
        Destino = destino;
    }

    public void Cancelar(){
        //cancelamento 
        Reservado = false;
        System.Console.WriteLine("Reserva cancelada");
    }
    public void Reservar(){
        //reserva
        Reservado = true;
        System.Console.WriteLine("Reservado para classe Regular");
    }
    public void Status(){
        System.Console.WriteLine("STATUS REGULAR:");
        System.Console.WriteLine("Data: " + Data);
        System.Console.WriteLine("Origem: " + Origem);
        System.Console.WriteLine("Destino: " + Destino);
        System.Console.WriteLine("Reserva Regular:" + Reservado);
    }
}