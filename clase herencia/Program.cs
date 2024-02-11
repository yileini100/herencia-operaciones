// See https://aka.ms/new-console-template for more information
using clase_herencia;
using System;
using System.Runtime.Intrinsics.X86;

Console.WriteLine("OPERACIONES ARITMETICAS");
Console.WriteLine();

int resultdo_suma, resultado_resta, resultado_multiplicacion;

Suma suma = new Suma();
Console.WriteLine("OPERACION SUMA");
Console.WriteLine();
Console.Write("valor 1: ");
suma.valor1 = Convert.ToInt32(Console.ReadLine());
Console.Write("valor 2: ");
suma.valor2 = Convert.ToInt32(Console.ReadLine());
resultdo_suma= suma.Operar();
Console.WriteLine($"El resultado de la suma es {resultdo_suma}");
Console.WriteLine();

Multiplicacion multiplicacion = new Multiplicacion();
Console.WriteLine("OPERACION MULTIPLICACION");
Console.WriteLine();
Console.Write("valor 1: ");
multiplicacion.valor1 = Convert.ToInt32(Console.ReadLine());
Console.Write("valor 2: ");
multiplicacion.valor2 = Convert.ToInt32(Console.ReadLine());
resultado_multiplicacion = multiplicacion.Operar();
Console.WriteLine($"El resultado de la suma es {resultado_multiplicacion}");
Console.WriteLine();

Resta resta = new Resta();
Console.WriteLine("OPERACION RESTA");
Console.WriteLine();
Console.Write("valor 1: ");
resta.valor1 = Convert.ToInt32(Console.ReadLine());
Console.Write("valor 2: ");
resta.valor2 = Convert.ToInt32(Console.ReadLine());
resultado_resta = resta.Operar();
Console.WriteLine($"El resultado de la suma es {resultado_resta}");
Console.WriteLine();

