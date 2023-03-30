//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;

namespace ConsoleApplication
{
    // Programa de consola de demostración.
    public static class Program
    {
        // Punto de entrada al programa principal.
        public static void Main()
        {
            for (int x = 1; x <= 25000; x++)
            {
                // Creo 1000 instancias de la clase Train 
                var tren = new Train("");
            }

            var train1 = new Train("Last Train to London");
            var train2 = new Train("Last Train to London");
            var train3 = new Train("Runaway Train");
            train1.StartEngines();
            Console.WriteLine("Hello World!");
            // Imprimo cuantos trenes hay vivos hasta el momento
            Console.WriteLine($"En este momento hay {Train.GetCount()} objetos de la clase Train en la memoria.");
            Console.WriteLine($"Las variables train1 y train2, ¿apuntan al mismo objeto? {train1 == train2}");
            Console.WriteLine($"Las variables train2 y train3, ¿apuntan al mismo objeto? {train2 == train3}");
            train1.StopEngines();
        }
    }
}
/*
Las tres variables train1, train2 y train3 son 3 instancias distintas de la clase Train.

Por lo tanto, si bien train1 y train 2 son iguales, porque en ambos casos la propiedad Id contiene el valor "Last Train to London",
al evaluar {train1 == train2} el resultado va a ser False. Esto es porque los objetos referenciados por cada variable son diferentes, son dos
objetos distintos, cada uno ocupa un espacio diferente en el heap de la memoria. Esta explicación también justifica el resultado de la comparación
{train1 == train2}, aunque es más intuitivo entender porque en este caso la respuesta también es False.
*/