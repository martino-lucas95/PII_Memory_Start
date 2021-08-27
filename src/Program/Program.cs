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
            Demo demo1 = new Demo("Demo 1");
        }

        private static void DestroyUnaccesibleObjects()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
   }
}