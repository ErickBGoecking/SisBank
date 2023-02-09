using SisBank;

Conta contaErick = new Conta();
contaErick.nome = "Erick Braun";
contaErick.agencia = 0396;
contaErick.conta = "1015851-6";
contaErick.saldo = 1000;
contaErick.cpf = 01526957612;
Console.WriteLine("Saldo = " + contaErick.saldo);

contaErick.Depositar(500);
Console.WriteLine("Saldo após o deposito = " + contaErick.saldo);

contaErick.Sacar(250);
Console.WriteLine("Saldo após o saque = " + contaErick.saldo);

