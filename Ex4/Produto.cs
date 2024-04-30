//ex4
public class Produto{
    public string Nome{get;set;}
    public double Preco{get;set;}
    public int QuantidadeEmEstoque{get;set;}

    public Produto(string nome, double preco, int quantidadeEmEstoque){
        Nome = nome;
        Preco = preco;
        QuantidadeEmEstoque = quantidadeEmEstoque;
    }

    public void ExibirInfo(){
        Console.WriteLine($"Nome:{Nome} - Preço:{Preco} - Quantidade em Estoque:{QuantidadeEmEstoque}");
    }

    public void AdicionarUnidade(int quantidade){
        if(quantidade > 0){
            QuantidadeEmEstoque += quantidade;
            Console.WriteLine("Foram adicionados:" + quantidade + " No estoque do produto: " + Nome);
            Console.WriteLine("Quantidade atualizada: " + QuantidadeEmEstoque);
        }else{
            Console.WriteLine("Quantidade deve ser maior que 0");
        }
    }

    public void RemoverUnidade(int quantidade){
        if(quantidade > 0 && quantidade <= QuantidadeEmEstoque){
            QuantidadeEmEstoque -= quantidade;
            Console.WriteLine("Foram removidos: " + quantidade);
            Console.WriteLine("Quantidade em estoque atualizada:" + QuantidadeEmEstoque);
        }else if(quantidade > QuantidadeEmEstoque){
            Console.WriteLine("Quantidade exede valor em estoque");
        }
    }

    public double CalcularValorTotal(){
        return Preco * QuantidadeEmEstoque;
    }

}