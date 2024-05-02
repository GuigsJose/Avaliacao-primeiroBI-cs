//ex 10

public class VooUpgrade : Voo{
    public VooUpgrade(string data, string origem, string destino) : base(data, origem, destino){
        Data = data;
        Origem = origem;
        Destino = destino;
    }

    public override void Reservar(){
        Console.WriteLine("Voo com Upgrade de Classe reservado para:" + Destino);
        StatusVoo = "Reservado";
    }
    public override void Cancelar(){
        Console.WriteLine("Reserva do Voo com Upgrade de Classe para: " + Destino + " CANCELADO");
        StatusVoo = "Cancelado";
    }
    public override void Status(){
        Console.WriteLine("Voo com Upgrade de Classe");
        Console.WriteLine("Origem: " + Origem);
        Console.WriteLine("Destino: " + Destino);
        Console.WriteLine("Data: " + Data);
        Console.WriteLine("Status: " + StatusVoo);
    }
}