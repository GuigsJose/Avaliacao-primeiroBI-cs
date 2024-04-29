public class CartaoDebito : IPagamento{
	public void ProcessarPagamento(){
        Console.WriteLine("Pagamento processado com Cartão de Debito");
    }
    public void EstornarPagamento(){
        Console.WriteLine("Pagamento com Cartão de Debito estornado");

    }
}
