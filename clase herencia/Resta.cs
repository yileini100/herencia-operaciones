using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_herencia
{
    public class Resta:Operacion
    {
        public int Operar()
        {
            resultado = valor1 - valor2;
            return resultado;

        }
    }
}
