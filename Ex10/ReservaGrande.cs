//ex 10
public class ReservaGrande : IReserva{
    public string classe = "Reserva Grande";
    public bool Reservado{get;set;}
    public string Data{get;set;}
    public string Origem{get;set;}
    public string Destino{get;set;}

    public ReservaGrande(string data,string origem, string destino){
        Data = data;
        Origem = origem;
        Destino = destino;
    }
    public void Cancelar(){
        //reserva com upgrade
        System.Console.WriteLine("Reservado para classe executiva");
        Reservado = false;
    }
    public void Reservar(){
        //reserva com uppgrade
        Reservado = true;
    }
    public void Status(){
         System.Console.WriteLine("STATUS RESERVA GRANDE:");
        System.Console.WriteLine("Data: " + Data);
        System.Console.WriteLine("Origem: " + Origem);
        System.Console.WriteLine("Destino: " + Destino);
        System.Console.WriteLine("Reserva Regular:" + Reservado);
    }
}