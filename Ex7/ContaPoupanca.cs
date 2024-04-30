//EX7

public class ContaPoupanca : ContaBancaria{
    public double TaxaJurosAnual{get;}
    public ContaPoupanca(double taxajurosAnual){
        TipoConta = "Conta Poupanca";
        TaxaJurosAnual = taxajurosAnual;
    }

    //SCRIPT: como calcula o juros anual na conta poupança?
    public void CalcularJuros(){
        double juros = Saldo * (TaxaJurosAnual / 12)/100;
        Saldo += juros;
    }
}