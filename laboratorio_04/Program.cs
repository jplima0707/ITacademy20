namespace Name
{
    class Program
    {
        static void Main(string[] args){
            ContaCorrente minhaConta = new ContaCorrente(250);
            minhaConta.depositar(100);
            minhaConta.sacar(50);

            Console.WriteLine("Saldo: "+ minhaConta.Saldo);
            Console.WriteLine("Criação: "+ minhaConta.Dt);
            Console.WriteLine("Saldo Medio: "+ minhaConta.SaldoMedio);
        }
    }
}
