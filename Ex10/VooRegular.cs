//ex 10

public class VooRegular : Voo{
    public VooRegular(string data, string origem, string destino) : base(data, origem, destino){
        Data = data;
        Origem = origem;
        Destino = destino;
    }

    public override void Reservar(){
        Console.WriteLine("Voo Regular reservado para:" + Destino);
        StatusVoo = "Reservado";
    }
    public override void Cancelar(){
        Console.WriteLine("Reserva do Voo Regular para: " + Destino + " CANCELADO");
        StatusVoo = "Cancelado";
    }
    public override void Status(){
        Console.WriteLine("Voo Regular");
        Console.WriteLine("Origem: " + Origem);
        Console.WriteLine("Destino: " + Destino);
        Console.WriteLine("Data: " + Data);
        Console.WriteLine("Status: " + StatusVoo);
    }
}