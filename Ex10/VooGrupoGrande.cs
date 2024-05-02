//ex10

//ex 10

public class VooGrupoGrande : Voo{
    public VooGrupoGrande(string data, string origem, string destino) : base(data, origem, destino){
        Data = data;
        Origem = origem;
        Destino = destino;
    }

    public override void Reservar(){
        Console.WriteLine("Voo de Grupos Grandes para:" + Destino);
        StatusVoo = "Reservado";
    }
    public override void Cancelar(){
        Console.WriteLine("Reserva de Grupos Grandes para: " + Destino + " CANCELADO");
        StatusVoo = "Cancelado";
    }
    public override void Status(){
        Console.WriteLine("Voo de Grupos Grandes");
        Console.WriteLine("Origem: " + Origem);
        Console.WriteLine("Destino: " + Destino);
        Console.WriteLine("Data: " + Data);
        Console.WriteLine("Status: " + StatusVoo);
    }
}