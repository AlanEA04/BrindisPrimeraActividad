namespace BrindisPrimeraActividad
{
    internal class Program
    {
        static void Main(string[] args)
        {
         

            int numero1, numero2;
            int respuesta;
            int opcion = 0;
            
            
            
            while (opcion !=5)
            {
                Console.WriteLine("1--Suma");
                Console.WriteLine("2--Resta");
                Console.WriteLine("3--Divicion");
                Console.WriteLine("4--Multiplicacion");
                Console.WriteLine("5--Salir");
                opcion =Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {

                    case 1:

                        Console.WriteLine("ingresa el Primer Numero");
                        numero1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("ingresa el segundo numero");
                        numero2 = Convert.ToInt32(Console.ReadLine());

                        respuesta = numero1 + numero2;
                        Console.WriteLine("El Resultado es el siguiente " + respuesta);
                     break;
                    
                    case 2:
                        Console.WriteLine("ingresa el Primer Numero");
                        numero1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("ingresa el segundo numero");
                        numero2 = Convert.ToInt32(Console.ReadLine());

                        respuesta = numero1 - numero2;
                        Console.WriteLine("El Resultado es el siguiente " + respuesta);
                    break;
                    
                    case 3:
                        Console.WriteLine("ingresa el Primer Numero");
                        numero1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("ingresa el segundo numero");
                        numero2 = Convert.ToInt32(Console.ReadLine());

                        respuesta = numero1 / numero2;
                        Console.WriteLine("El Resultado es el siguiente " + respuesta);

                    break; 

                    case 4:
                        Console.WriteLine("ingresa el Primer Numero");
                        numero1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("ingresa el segundo numero");
                        numero2 = Convert.ToInt32(Console.ReadLine());

                        respuesta = numero1 * numero2;
                        Console.WriteLine("El Resultado es el siguiente " + respuesta);
                        break; 
                    case 5:
                    break;



                }

            }
           


        }
    }
}