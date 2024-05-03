//ex10

public class Balcao{

    public string classe{get;set;}
    public string Reserva(IReserva r){
        return "reservado" + classe;
    }

    public string Cancela(IReserva r){
        return "cancelado";
    }

    public string Status(IReserva r){
        return "informações" + classe;
    }

}