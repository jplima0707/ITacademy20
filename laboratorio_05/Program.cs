using System.Collections;
public class Program
{
    static void Main(string[] args){
        
        Circulo circ1 = new Circulo(); 
        Circulo circ2 = new Circulo(2.4, 5, 3); 
        CirculoColorido circ3 = new CirculoColorido(); 
        CirculoColorido circ4 = new CirculoColorido(1.5, 3.1, 1, "vermelho"); 

        ArrayList array = new ArrayList();
        array.Add(circ1);
        array.Add(circ2);
        array.Add(circ3);
        array.Add(circ4);

        foreach (Circulo cir in array)
        {
            Console.WriteLine(cir.ToString());
        }
    
    }
}