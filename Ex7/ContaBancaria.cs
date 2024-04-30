// ex7

public class ContaBancaria : IContaBancaria{
    
    public ContaBancaria(){
        Saldo = 0;
    }
    public string NumeroConta{get;set;}
    public double Saldo{get;set;}
    public string TipoConta{get;set;}

    public void Depositar(double valor){
        Saldo += valor;
    }

    public void Sacar(double valor){
        if(valor <= Saldo){
            Saldo -= valor;
        }else{
            Console.WriteLine("Valor maior que o saldo.");
        }
    }

    public void ExibeInfo(){
        Console.WriteLine($"Numero da Conta:{NumeroConta} - Saldo: {Saldo} - Tipo da Conta: {TipoConta}");
    }
}