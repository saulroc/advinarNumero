
public class Program
{
    public static void Main(String[] args)
    {
        string[] mensajesIntroduccion = new string[3] {
           "Tiene tres intentos para demostar sus capacidades adivinatorias o dejar en evidencia su posible falta de capacidades,\n ¡Adelante con el primer intento!",
           "¡Vaya! Parece que no lo has averiguado, te quedan dos intentos más. \nIntente adivinar el número otra vez",
           "¡Uff! Parece que has vuelto a fallar, te queda un último intento." 
        };
        const int numeroIntentosMaximos = 3;
        const string mensajeBienvenida = @"Bienvenidos a la prueba mortal de la adivinanza de números,
la prueba consiste en adivinar un número que nuestros superordenadores han determinado al azar
mediante complejos logaritmos.

Dicho número se haya comprendido entre el 0 y el 16, dispone de 3 intentos para averiguarlo.
 Recuerde, aquí se esta jugando con algo más valioso que su vida; su dignidad.
 Así pues comencemos.";
        const int valorMinimo = 0;
        const int valorMaximo = 16;
        var generadorAleatorio = new Random();
        int numeroMagico = generadorAleatorio.Next(valorMinimo, valorMaximo);
        //Console.WriteLine($"El numero a adivinar era {numeroMagico}");
        
        Console.Title = "ADIVINACIÓN Y OTRAS COSAS"; 
        Console.WriteLine(mensajeBienvenida);
        int numeroIntroducidoPorElUsuario = 0;
        int intentos = 0;
        while ((numeroIntroducidoPorElUsuario != numeroMagico) && (intentos < numeroIntentosMaximos))
        {            
            //Console.WriteLine("Intentos restantes:" + (numeroIntentosMaximos - intentos));
            Console.WriteLine(mensajesIntroduccion[intentos]);
            numeroIntroducidoPorElUsuario = Convert.ToInt32(Console.ReadLine());
            intentos++;
            if (numeroIntroducidoPorElUsuario < numeroMagico)
            {
                Console.WriteLine("Te quedaste por debajo del número aleatorio...");                
            }
            else if (numeroIntroducidoPorElUsuario > numeroMagico)
            {
                Console.WriteLine("Te quedaste por encima del número aleatorio...");                
            }
        }

        if(numeroIntroducidoPorElUsuario==numeroMagico)
        {
            Console.WriteLine("Enhorabuena :D ,el numero era;" + numeroMagico);
        }
        else
        {
            Console.WriteLine($"Ohhh... que lástima... Te has quedado sin intentos y el juego ha terminado. El numero a adivinar era {numeroMagico}");            
        }
    }
}
