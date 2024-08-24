using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula3_cs_ex6
{
    public class Converter
    {
        public bool Validação(string valorS) 
        {
            if(valorS.Length > 6) 
            {
                Console.WriteLine("Erro 0, valor invalido de caracteres");
                return false;

            }
            foreach (char c in valorS)
            {
                if (c != '0' && c != '1')
                {
                    Console.WriteLine("Erro 1, valor não é binario");
                    return false;
                }
            }
            return true;        
        }
        public int logica(string valorS) 
        {
            int valordecimal = Convert.ToInt32(valorS, 2);
            return valordecimal;
        }
    }
}
