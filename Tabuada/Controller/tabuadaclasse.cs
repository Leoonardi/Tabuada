using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada.Controller
{
    internal class tabuadaclasse
    {
        //metodo do calcular a tabuada
        public string calcularTabuada(int valor)
        {
            string valorCalculo = "";


            for (int i = 0; i < 10; i++)
            {

                valorCalculo = "\n" + valor + " x " + i + " = " + valor * i;

            }


            return valorCalculo;
        }


        //metodo de limpar registros
    }
}
