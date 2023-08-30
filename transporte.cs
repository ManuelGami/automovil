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
        public void acelarar()
        {
            Console.WriteLine("estas llendo a {0}", velocidad);
            Console.WriteLine("a que velocidad quieres llegar en km/hr ");
            float VF = float.Parse(Console.ReadLine());
            Console.WriteLine("en cuanto tiempo quieres llegar a {0} en segundos", VF);
            float t = float.Parse(Console.ReadLine());
            Console.WriteLine("tienes que acelar a {0} kh/s^2", (VF-velocidad)/t);
        }
        public void frenar()
        {
            Console.WriteLine("estas llendo a {0}", velocidad);
            Console.WriteLine("en cuanto tiempo quieres frenar");
            float t = float.Parse(Console.ReadLine());
            Console.WriteLine("tienes que desacelerar a {0} kh/s^2 para frenar en el tiempo deseado", (0 - velocidad) / t);
        }

        #endregion
        
    }
}
