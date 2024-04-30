// ex7 

public class ContaEmpresarial : ContaBancaria{
    public double SaldoMinEx{get;}
    public ContaEmpresarial(double saldoMinEx){
        TipoConta = "Conta Empresarial";
        SaldoMinEx = saldoMinEx;
    }
    
    public void VerificaSaldoMinimo(){
        if(Saldo < SaldoMinEx){
            Console.WriteLine("Saldo abaixo do minimo exigido");
        }else{
            Console.WriteLine("Saldo atende o minimo exigido");
        }
    }
}