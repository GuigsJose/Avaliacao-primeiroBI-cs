public class ReservaUpgrade : IReserva{
    public string classe = "Executiva";
    public bool Reservado{get;set;}
    public string Data{get;set;}
    public string Origem{get;set;}
    public string Destino{get;set;}

    public ReservaUpgrade(string data,string origem, string destino){
        Data = data;
        Origem = origem;
        Destino = destino;
    }
    public void Cancelar(){
        Reservado = false;
        System.Console.WriteLine("Reserva cancelada");
    }
    public void Reservar(){
        Reservado = true;
        System.Console.WriteLine("Reservado para classe executiva");
    }
    public void Status(){
        System.Console.WriteLine("STATUS RESERVA UPGRADE:");
        System.Console.WriteLine("Data: " + Data);
        System.Console.WriteLine("Origem: " + Origem);
        System.Console.WriteLine("Destino: " + Destino);
        System.Console.WriteLine("Reserva Regular:" + Reservado);
    }
}