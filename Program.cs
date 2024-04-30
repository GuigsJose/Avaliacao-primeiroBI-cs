//ex 3 
Animal animal1 = new Cachorro();
Animal animal2 = new Gato();

animal1.EmitirSom();//latindo
animal2.EmitirSom();//miando

//ex4 
Produto produto = new Produto("Camiseta",29.99,10);

produto.ExibirInfo();

produto.AdicionarUnidade(10);
produto.RemoverUnidade(5);

//ex 5 
Filme filme = new Filme("Titanic","Românce",150);
filme.ExibeInfo();
filme.VerificaDisponibilidade();
filme.RegistrarLocacao();
filme.VerificaDisponibilidade();
filme.RegistrarDevolucao();
filme.VerificaDisponibilidade();

//ex 6 
Carro carro = new Carro(0);
carro.Rodas = 4;
carro.Portas = 2;

Moto moto = new Moto(0);
moto.Rodas = 2;
moto.Cilindradas = 250;

Bicicleta bike = new Bicicleta(0);
bike.Rodas = 2;
bike.NumeroMarchas = 7;

// ex 7

ContaCorrente cr = new ContaCorrente();
cr.NumeroConta = "123321";
cr.Saldo = 2000;
cr.Depositar(1000);
cr.Sacar(200);
cr.ExibeInfo();

ContaPoupanca cp = new ContaPoupanca(0.5);
cp.NumeroConta = "989893";
cp.Depositar(2000);
cp.CalcularJuros();
cp.Sacar(100);
cp.ExibeInfo();

ContaEmpresarial ce = new ContaEmpresarial(5000);
ce.Depositar(5600);
ce.NumeroConta = "923847628";
ce.Sacar(100);
ce.ExibeInfo();
ce.VerificaSaldoMinimo();
