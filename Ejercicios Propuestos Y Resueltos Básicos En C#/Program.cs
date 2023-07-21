// ********** Ejercicios Propuestos Y Resueltos Básicos En C# **********


/* 1) Crear 3 variables numéricas con el valor que tu quieras y en otra variable numérica guardar el valor de la suma de las 3 anteriores. 
  Mostrar por consola.*/


float numero1 = 4, numero2 = 14, numero3 = 2, resultado = 0;

resultado = numero1 + numero2 + numero3;

Console.WriteLine(resultado);
Console.ReadLine();


/* 2) Pedir por consola un nombre de persona y el nombre de una ciudad (no hace falta que sean reales o comprobarlos)
 y mostrar por pantalla, el siguiente mensaje «Hola » <nombre> » bienvenido a » <ciudad> */

Console.WriteLine("Ingrese su Nombre");
string nombre = Console.ReadLine();

Console.WriteLine("Ingrese su Ciudad");
string ciudad = Console.ReadLine();

Console.WriteLine("Hola {0} Bienvenido a {1}", nombre, ciudad);
Console.ReadLine();

//3) Pedir por consola tu nombre y tu edad y mostrar el siguiente mensaje: «Te llamas » <nombre> » y tienes » <años> » años»


Console.WriteLine("Ingrese su Nombre");
string nombre1 = Console.ReadLine();

Console.WriteLine("Ingrese su edad");
int edad = int.Parse(Console.ReadLine());

Console.WriteLine("Te llamas {0} y tienes {1} años", nombre1, edad);
Console.ReadLine();


//4) Pedir dos números al usuario por teclado y decir que número es el mayor.


Console.WriteLine("Ingrese el primer numero");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el segundo numero");
int num2 = int.Parse(Console.ReadLine());


if (num1 > num2)
{
    Console.WriteLine("El numero mayor es el {0}", num1);
}
else if (num1 < num2)
{
    Console.WriteLine("El numero mayor es el {0}", num2);
}
Console.ReadLine();


//5) Pedir el nombre del dia al usuario y decirle si es fin de semana o no.  En caso de error, indicarlo.


Console.WriteLine("Ingrese el dia");
string dia = Console.ReadLine().ToLower();

switch (dia)
{
    case "lunes":

        Console.WriteLine("El dia {0} no es fin de semana", dia);
        break;

    case "martes":

        Console.WriteLine("El dia {0} no es fin de semana", dia);
        break;

    case "miercoles":

        Console.WriteLine("El dia {0} no es fin de semana", dia);
        break;

    case "jueves":

        Console.WriteLine("El dia {0} no es fin de semana", dia);
        break;

    case "viernes":

        Console.WriteLine("El dia {0} no es fin de semana, casi pero no", dia);
        break;

    case "sabado":

        Console.WriteLine("El dia {0} si es FIN DE SEMANA!!", dia);
        break;

    case "domingo":

        Console.WriteLine("El dia {0} si es FIN DE SEMANA!!", dia);
        break;

    default:
        Console.WriteLine("El dia ingresado es incorrecto, intente nuevamente");
        break;
}
Console.ReadLine();


/* 6) Pedir al usuario el precio de un producto (valor positivo) y la forma de pagar (efectivo o tarjeta)
   si la forma de pago es mediante tarjeta, pedir el numero de cuenta (inventado)*/

Console.WriteLine("Escribe el precio del producto");
double precio = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Escribe la forma de pago: tarjeta o efectivo");
String forma = (Console.ReadLine()).ToLower();

if (forma.Equals("tarjeta"))
{
    Console.WriteLine("Introduce el numero de tarjeta");
    int numero_cuenta = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("El producto con precio " + precio + " se ha pagado " +
    "con el numero de cuenta " + numero_cuenta);
}
else if (forma.Equals("efectivo"))
{
    Console.WriteLine("El producto con precio " + precio + " se ha pagado");
}
else
{
    Console.WriteLine("La forma de pago no es correcta");
}
Console.ReadLine();

//7) Recorre los números del 1 al 100. Usa un bucle for.


Console.WriteLine("Elija el limite del Bucle");
int limit = int.Parse(Console.ReadLine());

for (int i = 1; i <= limit; i++)
{
    Console.WriteLine("Numero: {0}", i);
}
Console.ReadLine();


//8) Recorre los números del 1 al 100. Usa un bucle while.


Console.WriteLine("Elija el limite del Bucle");
int limite = int.Parse(Console.ReadLine());
int a = 1;

while (a <= limite)
{
    Console.WriteLine("Numero: {0}", a);
    a++;
}
Console.ReadLine();


//9) Recorre los números del 1 al 100. Muestra los números pares. Usar el tipo de bucle que quieras.

Console.WriteLine("Elija el limite del Bucle");
int limt = int.Parse(Console.ReadLine());

for (int b = 1; b <= limt; b++)
{
    if (b % 2 == 0)
    {
        Console.WriteLine("\nNumero: {0} *ES PAR*", b);
    }
    else
    {
        Console.WriteLine("\nNumero: {0}", b);
    }
}
Console.ReadLine();

//10) Recorre los números del 1 al 100. Muestra los números pares o divisibles entre 3.


Console.WriteLine("Elija el limite del Bucle");
int limite1 = int.Parse(Console.ReadLine());

for (int c = 1; c <= limite1; c++)
{
    if (c % 2 == 0)
    {
        Console.WriteLine("\nNumero: {0}", c);
    }
    else
    {
        Console.WriteLine("\nNumero: {0} *ES IMPAR*", c);
    }
}
Console.ReadLine();

