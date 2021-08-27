//----------------------------------------------------------------------
// <copyright file="Demo.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//----------------------------------------------------------------------

using System;

namespace Memory
{
    /// <summary>
    /// Una clase de ejemplo para mostrar constructores y destructores. En la vida real no es necesario implementar un
    /// destructor. En caso de que sea necesario que algo suceda deben implementar IDisposable.
    /// </summary>
    public class Demo
    {
        /// <summary>
        /// Crea una nueva instancia.
        /// </summary>
        /// <param name="text">Texto que representa el estado del objeto creado.</param>
        public Demo(string text)
        {
            this.Text = text;
            Console.WriteLine($"Construyendo {this.Text}...");
        }

        /// <summary>
        /// Una propiedad para demostrar el estado del objeto.
        /// </summary>
        /// <value>Obtiene o establece el texto que representa el estado del objeto.</value>
        public string Text { get; set; }

        /// <summary>
        /// Finaliza una instancia de la clase Demo.
        /// </summary>
        ~Demo()
        {
            Console.WriteLine($"Destruyendo {this.Text}...");
        }
    }
}