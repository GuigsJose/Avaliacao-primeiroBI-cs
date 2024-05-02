// ex9

public class TransferenciaBancaria : IMetodoPagamento{
    public double Saldo{get;set;}
    public bool PagamentoRealizado{get;set;}
    public TransferenciaBancaria(double saldo){
        Saldo = saldo;
    }
    public void RealizarPagamento(double valor){
        if(valor <= Saldo){
            Saldo -= valor;
            PagamentoRealizado = true;
        }else{
            Console.WriteLine("Valor exede o saldo");
            PagamentoRealizado = false;
        }
    }

    public void Status(){
        Console.WriteLine("Pagamento realizado: " + PagamentoRealizado);
        
    }
}