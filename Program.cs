// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/* Comentarios en C#
 * SERBIAA!!!
 * SERBIAAAAA!!!!!!!
 * SERBIAAAAAAA!!!!!!!!!!!!!!!!!!!!
 */

//Tipos de datos mas conocidos

//Enteros

int num1, num2;  //El integer es de 32 bits
int valor1 = 56;

long l = 654764578; //Numeros enteros pero con mas tamano (64 bits)

byte b = 255; //8 bits

valor1 += 7*8;

short s = 5654;

//Flotantes
float f = 120.5f; //4 bytes
double d = 5.654d; //8 bytes
decimal dec = 35665.12m;

//Booleanos
bool boleano = false;

//Caracteres
string nombre = "Gordon"; //El string es para cadenas de caracteres y es de 64 bits
string apellido = "Freeman";
char caracter = 'a'; //Los char solo pueden tener solo un caracter

Console.WriteLine(nombre + " " + apellido);

//Preguntar por el nombre
//Console.WriteLine("Digite un nombre");
//nombre = Console.ReadLine();

//Console.WriteLine("Su nombre es: " + nombre + " " + apellido);

num1 = 10;
num2 = 3;
//Console.WriteLine("Sumar: " + (num1 + num2));
//Console.WriteLine("Multiplicar: " + (num1 * num2));

//Console.WriteLine("Digite un valor:");
//num1 = int.Parse(Console.ReadLine()); // El readline lee los datos que se insertan como texto

//Console.WriteLine("Digite otro valor:");
//num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Multiplicar: " + (num1 * num2));
float camisas = 100;
float pantalones = 200;
float medias = 50;

float precio = 400;
float total = 0;
int cantidad = 0;
float IVA = 0;
float stotal = 0;
float descuento = 0;
int opcion = 0;
string articulo = "";

do
{
    Console.Clear(); //Limpia la pantalla
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("[***** TIENDA LA BARATIJA *****]");
    Console.WriteLine("¿Qué desea comprar?");
    Console.WriteLine("1- Camisas");
    Console.WriteLine("2- Pantalones");
    Console.WriteLine("3- Medias");
    opcion = int.Parse(Console.ReadLine());

    if (opcion == 0)
    {
        precio = camisas;
        articulo = "Camisas";
    }
    else if (opcion == 2)
    {
        precio = pantalones;
        articulo = "Pantalones";
    }
    else if (opcion == 3)
    {
        precio = medias;
        articulo = "Meidas";
    }
} while (opcion < 1 || opcion > 3);

Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine("Digite la cantidad:");
cantidad = int.Parse(Console.ReadLine());
Console.WriteLine("Digite el porcentaje de descuento:");
descuento = int.Parse(Console.ReadLine());
stotal = cantidad * precio;
Console.WriteLine("El subtotal a pagar es de: {0}", stotal); //Los numeros entre llaves es determinar un parametro que se remplaza con las variables que se dan
descuento = stotal * (descuento / 100);
Console.WriteLine("El descuento es {0}", descuento);
stotal = stotal - descuento;
Console.WriteLine("El subtotal con descuento {0}", stotal);
Console.WriteLine("El descuento es {0}", descuento);
IVA = stotal / 0.13f;
Console.WriteLine("El impuesto es {0}", IVA);
Console.WriteLine("El total a pagar es de {0}", stotal + IVA,articulo);