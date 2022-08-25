//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            var train = new Train("train");
            train.StartEngines();
            Console.WriteLine("Hello World!");

            var t1 = new Train("Last Train To London");
            var t2 = new Train("Last Train To London");
            var t3 = new Train("Runaway Train");
        } 
    }
}