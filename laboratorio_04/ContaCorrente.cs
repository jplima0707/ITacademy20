using System; 
 
class ContaCorrente { 
    private decimal saldo;
    private DateTime dt;
    private int operacoes;
    private decimal saldoMedio;

    public ContaCorrente(decimal val){
        saldo = val;
        dt = DateTime.Now;
        operacoes = 0;
        saldoMedio = val;

    }

    public decimal Saldo{
        get{return saldo;}
    }

    public decimal SaldoMedio{
        get{return saldoMedio/operacoes;}
    }

    public DateTime Dt{
        get{return dt;}
    }

    public void depositar(decimal d){
        saldo += d;
        saldoMedio += saldo;
        operacoes++;
    }

    public void sacar(decimal d){
        saldo -= d;
        saldoMedio += saldo;
        operacoes++;
    }
}
