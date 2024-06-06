// See https://aka.ms/new-console-template for more information
namespace Laboratorio_1;
class Program{
    static void Main(string [] args){
        byte b;
        int i;
        long l;

        b = byte.MaxValue;
        i = int.MaxValue;
        l = long.MaxValue;

        Console.WriteLine("Valor maximo do byte: " +b);
        Console.WriteLine("Valor maximo do int: " +i);
        Console.WriteLine("Valor maximo do long: " +l); 

        string primeira = "Oi ";
        string segunda =  "Bom dia";
        string terceira = primeira + segunda;

        string greeting = "      Hello World!       ";
        Console.WriteLine($"[{greeting}]");

        string trimmedGreeting = greeting.Trim();
        Console.WriteLine($"[{trimmedGreeting}]");

        DateTime dt = DateTime.Now;
        Console.WriteLine(dt);

        double valorFracionado = 4.4; 
        int valorInteiro1 = (int) valorFracionado; 
        int valorInteiro2 = Convert.ToInt32(valorFracionado); 
        Console.WriteLine("Conversao explicita = " + valorInteiro1); 
        Console.WriteLine("Conversao metodo Convert = " + valorInteiro2); 

        int x = 10; 
        double y = 3.4; 
        Console.WriteLine("{0} --> {1}",x,y); //utliza uma função diferente para sintaxe
        Console.WriteLine($"{x} / {y}");  
    } 
} 
