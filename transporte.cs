using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automoviles
{
    internal abstract class transporte
    {
        #region Atributos
        private string marca;
        private float precio;
        private float velocidad;

        public float Velocidad
        {
            get => velocidad;
            set
            {
                if (velocidad<0 && velocidad > 250)
                {
                    velocidad = 100;
                }
                else
                {
                    velocidad = value;
                }
            }
        }
        #endregion

        #region metodos
        public string MostrarProducto()
        {
            Console.WriteLine(" A: mercedes \n B: ferrari");
            Console.WriteLine("\nIngresa el nombre del producto: ");
            string marca = Console.ReadLine();
            Console.WriteLine("\n");
            return marca;
        }
        public string
        #endregion
        
    }
}
