// ex9

using System.Reflection.Metadata;

public class BoletoBancario : IMetodoPagamento{

    public bool Vencimento{get;set;}
    public int NumeroBoleto{get;set;}
    public bool PagamentoRealizado{get;set;}
    public bool TemDinheiro{get;set;}
    public double ValorBoleto{get;set;}
    
    public BoletoBancario(int numeroBoleto,double valorBoleto){
        NumeroBoleto = numeroBoleto;
        TemDinheiro = true;
        ValorBoleto = valorBoleto;
    }

    public bool BoletoVencido(bool vencimento){
        try{
            if(Vencimento == vencimento){
                return vencimento;
            }else{
                return vencimento;
            }
        }catch(Exception e){
            return vencimento;
        }   
    }

    public void RealizarPagamento(double valor){
        if(TemDinheiro == true){
            ValorBoleto = valor;
            PagamentoRealizado = true;
        }else{
            Console.WriteLine("Valor não alcançado para pagamento do boleto");
            PagamentoRealizado = false;
        }
    }

    public void Status(){
        Console.WriteLine("Pagamento realizado: "+ PagamentoRealizado);
    }
}