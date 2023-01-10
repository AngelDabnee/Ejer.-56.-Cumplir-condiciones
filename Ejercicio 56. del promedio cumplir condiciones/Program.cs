// See https://aka.ms/new-console-template for more information
using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Hello, World!");
//Que el usuario capture 20 números, si su promedio es capturados
//es menor a 24,determinar el menor, y si el
//promedio es mayor a 34, determinar cual es el
//mayor. Si esta entre 25 y 34 imprimir “FUERA”.
Console.WriteLine("Con este programa, promediaremos 20 números, si el promedio es menor de 24, te daré el menor, si es mayor que 34 te daré el mayor, pero si no es ninguno de estos te diré fuera");
//Datos de entrada
double[] numeros = new double[20];
double prom = 0;
double min = 0;
double max = 0;
double suma = 0;
//Proceso. 
for (int i = 0; i < numeros.Length; i++)//Comenzaremos con un ciclo para capturar los 20 numeros
{
    Console.WriteLine("Ingresa tu número No. " + (i+1));
    numeros[i] = double.Parse(Console.ReadLine());
    suma = suma + numeros[i];
    prom = suma / 20;
}
//Valoraremos la condición dependiendo del promedio
if (prom<24)//Comenzaremos valorando si prom<24 para arrojar el numero menor que capturó el usuario. 
{//Haremos el ordenamiento de la burbuja para esto. 
    for (int i = 0; i < numeros.Length; i++)//Dos for para poder sacar el menor dependieno de la posición
    {
        for (int k = 0; k < numeros.Length-1; k++)//Como comparamos en pares, necesitamos empezar con -numeros
        {
            if (numeros[k] > numeros[k+1])//Comparamos el primero con el segundo, si esto se cumple vamos a;
            {
                double temp = numeros[k];//Almacenamos el primero en la variable temp
                numeros[k] = numeros[k + 1];//Comparamos lo que este ahora en el 0 con el 1
                numeros[k + 1] = temp;//Si es menor vamos recorriendo los numeros
            }
        }
    }
    min = numeros[0];//La posición 0 es el menor, por el orden descendente que damos. 
    //Datos de salida 1 
    Console.WriteLine("El menor de los números capturados es " + min);
}
if (prom>34)//Valoraremos la segunda condición, de si es mayor que 34
{//Realizamos los mismos pasos que el anterior, solo que OJO. 
    for (int i = 0; i < numeros.Length; i++)
    {
        for (int l = 0; l < numeros.Length-1; l++)
        {
            if (numeros[l] < numeros[l+1])//Por el signo haremos un orden asendente, el mayor primero
            {//Seguimos con un ordenamiento de la burbuja.
                double temp = numeros[l];
                numeros[l] = numeros[l + 1];
                numeros[l + 1] = temp;//Aquí terminamos el intercambio, acomodando el mayor al inicio. 
            }
        }
    }
    max = numeros[0];//Por como acomodamos los arreglos, el mayor es el 0
    //Datos de salida 2
    Console.WriteLine("El mayor de los números capturados es " + max);

}
if (prom!>34&&prom!<24)//Valoramos la 3 condicion, si está dentro del 25 y del 34
{
    //Datos de salida 3. 
    Console.WriteLine("FUERA");
}