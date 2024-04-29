public class CartaoCredito : IPagamento{
	public void ProcessarPagamento(){
        Console.WriteLine("Pagamento processado com Cartão de Crédito");
    }
    public void EstornarPagamento(){
        Console.WriteLine("Pagamento com Cartão de Crédito estornado");

    }
}
