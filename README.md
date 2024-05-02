# UNIVERSIDADE POSITIVO
# TÓPICOS ESPECIALS EM DESENVOLVIMENTO DE SOFTWARE
# Prof Escobar

## Realize o que se pede:

1.	Explique o que é herança em orientação a objetos e como ela é implementada em C#. Dê um exemplo prático de como a herança pode ser utilizada em um sistema de gerenciamento de funcionários.
```
R: A Herança possibilita que as classes compartilhem seus atributos, métodos e outros membros da classe entre si. Onde classes derivadas herdam atributos de classes bases. Por exemplo:
```
```
public class Humano{
	public string Nome{get;set;}
	public string CPF{get;set;}
	public int Idade{get;set;}
	
	public void Falar(){

}
}

public class Bombeiro : Humano{
	public bool ApagarIncendio(){
		return true;
}
}
```

Uma classe base chamada Humano, que concedeu as características, e a classe derivada Bombeiro que herdou as características da classe base, e tem um método a mais que é apagar incêndio.

2.	O que são interfaces em orientação a objetos e qual é a sua importância na construção de sistemas em C#? Dê um exemplo de como uma interface pode ser utilizada para garantir a interoperabilidade entre diferentes classes em um sistema de pagamento online.
```
R: Interfaces são como um contrato entre a classe e o mundo exterior, as interfaces são fornecidas pela declaração de um ou mais métodos, os quais obrigatoriamente não possuem um corpo, sendo assim a interface é flexível quando é utilizado num contexto de polimorfismo. Exemplo:
```
```
public interface IPagamento{
	void ProcessarPagamento();
	void EstornarPagamento();
}

public class CartaoCredito : IPagamento{
	public void ProcessarPagamento(){
	      Console.Writeline(“Pagamento processado com cartão de Credito”);
	}
	Public void EstornarPagamento(){
	       Console.Writeline(“Pagamento com cartão de Credito estornado”);
	}
}

public class CartaoDebito : IPagamento{
	public void ProcessarPagamento(){
	      Console.Writeline(“Pagamento processado com cartão de Debito”);
	}
	Public void EstornarPagamento(){
	       Console.Writeline(“Pagamento estornado com cartão de Debito”);
	}
}
```


3.	Diferencie sobrecarga e sobreposição (ou sobrescrita) e forneça exemplos de cada um em C#.
```
R: sobrecarga ocorre quando uma classe tem dois ou mais métodos com o mesmo nome, mas com assinaturas diferentes(tendo diferentes tipos de parâmetros): Exemplo:
```
```
public class Calculadora{
	public int Somar(int a, int b){
		return a+b;
	}
	public double Somar(double a, double b){
		return a+b;
	}
}
```
     Sobreposição ocorre quando uma classe filha redefine um método de sua classe base, fornecendo uma implementação especifica para esse método na classe filha sempre utilizando a propriedade virtual que pode ser substituída em classes derivadas. Exemplo:
```
public class Animal{
	public virtual void EmitirSom(){`
		Console.Writeline(“som”);
	}
}
public class Cachorro : Animal{
	public override void EmitirSom(){
		Console.Writeline(“Latindo”);
	}
}
public class Gato : Animal{
	public override void EmitirSom(){
		Console.Writeline(“Miando”);
	}
}

Animal animal1 = new Cachorro();
Animal animal2 = new Gato();

animal1.EmitirSom();
animal2.EmitirSom();
```

4.	Crie uma classe Produto que represente um produto em uma loja online. A classe deve ter os seguintes “atributos: Nome, Preco, QuantidadeEmEstoque. Implemente métodos para adicionar e remover unidades do estoque, e um método para calcular o valor total do produto em estoque. Os métodos devem alterar o estado do objeto instanciado. ok


5.	Implemente um sistema para uma locadora de filmes. Crie uma classe Filme com os seguintes atributos: Titulo, Genero, Duracao, Disponivel (indicando se o filme está disponível para locação). Implemente métodos para registrar a locação de um filme, registrar a devolução de um filme e verificar se um filme está disponível para locação. Não há necessidade de implementar rotinas de bancos de dados. ok

6.	Implemente uma hierarquia de classes para representar diferentes tipos de veículos, como carros, motos e bicicletas. Cada classe deve herdar da classe base Veiculo. Adicione atributos específicos para cada tipo de veículo, como número de portas para carros, cilindrada para motos e número de marchas para bicicletas. ok


7.	Desenvolva um sistema de gerenciamento de contas bancárias com diferentes tipos de contas, 
como conta corrente, conta poupança e conta empresarial.
 Utilize herança para representar a relação entre as classes de contas e implemente métodos específicos para cada tipo de conta,
 como calcular juros para contas poupança e 
verificar saldo mínimo para contas empresariais.
Script IA: como calcula o juros anual na conta poupança?
Script IA: como calcula o saldo mínimo para contas empresariais?

8.	Crie uma aplicação para uma escola de idiomas que oferece diferentes tipos de cursos, como inglês, espanhol e francês.
 Utilize herança para representar a relação entre as classes de cursos e implemente métodos específicos para cada tipo de curso, como calcular a média de notas para cursos avançados e gerar certificados para cursos concluídos.
ok


9.	Desenvolva um sistema de processamento de pagamentos com diferentes métodos de pagamento, como cartão de crédito, boleto bancário e transferência bancária. Crie uma interface IMetodoPagamento com métodos para realizar o pagamento e verificar o status do pagamento. Implemente classes para cada método de pagamento que herdem dessa interface e forneça a lógica específica para cada método de pagamento.
ok

10.	Projete um sistema de reservas de voos para uma companhia aérea. Crie uma interface IReserva com métodos para reservar um voo, cancelar uma reserva e verificar o status da reserva. Implemente classes para diferentes tipos de reservas, como reserva de voo regular, reserva de voo com upgrade de classe e reserva de voo para grupos grandes. Utilize a interface para garantir a interoperabilidade entre os diferentes tipos de reservas.

ScriptIA:
qual a importancia de utilizar base numa herança, ou escrever override num método em c# e quando utilizar o virtual


# SCRIPTS IA's

QUESTÃO 7:
Script IA: como calcula o juros anual na conta poupança?
Script IA: como calcula o saldo mínimo para contas empresariais?

QUESTAO 10: ScriptIA:
qual a importancia de utilizar base numa herança, ou escrever override num método em c# e quando utilizar o virtual

