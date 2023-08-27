//Enunciado:
//Ingresar por pantalla 2 números y calcular las 4 operaciones aritméticas con
//dichos números. Imprimir en pantalla el resultado de cada operación.


//1ro: definir el nombre de mi clase con su respectivo metodo main
public class MiPrimerPrograma
{
    static void Main(string[] args)
    {
        //2do: declaracion de variables (datos de entrada)
        int num1, num2, suma, resta, producto, division;
    
        //3ro: pedir los valores por pantalla (consola):
        Console.Write("ingrese su primer numero: ");
        num1 = Convert.ToInt32(Console.ReadLine()); //Solamente recibe strings

        Console.Write("ingrese su segundo numero: ");
        num2 = Convert.ToInt32(Console.ReadLine()); //Solamente recibe strings

        //4to: calculos (procesos)
        suma = num1 + num2;
        resta = num1 - num2;
        producto = num1 * num2;
        division = num1 / num2;

        //5to imprimir los resultados (datos de salida)
        Console.Write("la suma es: " + suma);
        Console.Write("\n");
        Console.Write("la resta es: " + resta);
        Console.Write("\n");
        Console.Write("el producto es: " + producto);
        Console.Write("\n");
        Console.Write("la division es: " + division);
    }
    
    
}