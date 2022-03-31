//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Collections;

namespace Memory
{
    /// <summary>
    /// Clase que contiene el punto de entrada al programa.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// El punto de entrada al programa.
        /// </summary>
        public static void Main()
        {
            CreateLocalDemo();
            DestroyUnaccesibleObjects();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

    static void CreateLocalDemo()
    {
        Demo demo = new Demo("7");
    }
    static Demo CreateAndReturnDemo(string text)
    {
        Demo result = new Demo(text);
        return result;
    }

    static void RenameDemo(Demo demo, string text)
    {
        Console.WriteLine($"Cambiando de {demo.Text} a {text}");
        demo.Text = text;
    }
    static void NullifyDemo(Demo demo)
    {
        demo = null;
    }

        private static void DestroyUnaccesibleObjects()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
   }
}