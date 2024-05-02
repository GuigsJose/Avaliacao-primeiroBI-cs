//ex9

public class CartaoDeCredito : IMetodoPagamento{

    public double LimiteDisponivel{get;set;}
    public int NumeroCartao{get;set;}
    public string Vencimento{get;set;}
    public bool PagamentoRealizado{get;set;}

    public CartaoDeCredito(double limiteDisponivel, int numeroCartao, string vencimento){
        LimiteDisponivel = limiteDisponivel;
        NumeroCartao = numeroCartao;
        Vencimento = vencimento;
    }

    public void RealizarPagamento(double valor){
        try{
        if(valor <= LimiteDisponivel){
            Console.WriteLine("Realizando págamento no crédito...");
            PagamentoRealizado = true;
        }else{
            Console.WriteLine("Valor indisponivel, Limite insuficiente de Crédito.");
            PagamentoRealizado = false;
        }
        }catch(Exception e){
           Console.WriteLine("Erro ao processar o pagamento: " + e.Message);
           PagamentoRealizado = false;
        }
    }

    public void Status(){
        Console.WriteLine("Pagamento realizado: " + PagamentoRealizado);
    }
}