//--------------------------------------------------------------------------------
// <copyright file="Train.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;

namespace ClassLibrary
{
    // Esta clase representa un tren muy básico.
    public class Train
    {
        // Obtiene un valor que indica si las maquinas del tren han sido encendidas o no.
        // true si las máquinas fueron encendidas, false en caso contrario.
        public bool IsEngineStarted { get; private set; }
        // Creo la variable de clase count:
        private static int count = 0;
        // Creo la variable de instancia id, quien va a ser mi identificador:
        public string id;
        // Defino el constructor de la clase:
        public Train(string id)
        {
            this.id = id;
            // Cada vez que se cree una instancia, el contador va a aumentar:
            Train.count = Train.count + 1;
            //Console.WriteLine("Un tren fue creado");
        }
        // Defino un metodo para determinar el identificador de un tren:
        public void SetId(string value)
        {
            this.id = value;
        }
        // Defino un metodo para obtener el identificador de un tren:
        public string GetId()
        {
            return this.id;
        }
        // Defino un metodo para descubrir cuantos trenas hay creados hasta el momento:
        public static int GetCount()
        {
            return Train.count;
        }
        // Defino el destructor de la clase:
        ~Train()
        {
            Train.count--;
            //Console.WriteLine("Un tren fue destruido");
        }
        // Enciende las maquinas del tren.
        // Devuelve true si las maquinas fueron encendidas, false en caso contrario.
        public bool StartEngines()
        {
            if (this.IsEngineStarted)
            {
                Console.Write("The engines are already running \n");
                return false;
            }

            this.IsEngineStarted = true;
            Console.Write($"{this.id}. Engines on \n");
            return true;
        }
        // Detiene las maquinas del tren.
        // Devuelve true si las maquinas pueden ser detenidas, false en caso contrario.
        public bool StopEngines()
        {
            if (this.IsEngineStarted)
            {
                this.IsEngineStarted = false;
                Console.Write($"{this.id}. Engines off \n");
                return true;
            }

            Console.Write("The engines are already stopped \n");
            return this.IsEngineStarted;
        }
    }
}