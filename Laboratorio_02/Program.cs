namespace Name
{
    class Program
    {
        static void Main(string[] args){

            int[] array = new int[5] { 10, 20, 30, 40, 50 };

            foreach (int i in array) { 
                Console.WriteLine("Valor = " + i); 
            }

            string[] str = new string[3]; 
            int ist = 0;
            str[0] = "Um"; 
            str[1] = "Dois"; 
            str[2] = "Tres";

            foreach (string iStr in str) { 
                Console.WriteLine("Indice = " + ist + " Valor = " + iStr); 
                ist++;
            }

            DateTime[] dt = new DateTime[2];  
            dt[0] = new DateTime(2002, 5, 1); 
            dt[1] = new DateTime(2002, 6, 1); 
            foreach (DateTime iDate in dt) { 
                Console.WriteLine("Data = " + 
                iDate.ToShortDateString()); 
            }
        }
    }
}