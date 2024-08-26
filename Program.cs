using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula3_cs_ex6
{
    
    /*Escreva um programa em C# que leia um valor em binário até 6 dígitos e escreva o 
    número correspondente em decimal.*/
    
    internal class Program
    {
        bool valor = false;
        string valorstring;
        int valordecimal;
        static void Main(string[] args)
        {
            Program start = new Program();
        }
        public Program() 
        {
            Converter conversor = new Converter();
            while(valor != true)
            {
                Console.Write("Digite um valor em binario com até 6 caracteres: ");
                valorstring = Console.ReadLine();
                valor = conversor.Validação(valorstring);
            }
            valordecimal = conversor.logica(valorstring);
            Console.WriteLine("O valor decimal foi: {0}", valordecimal);
            Console.ReadKey();
        }
        
    
    }
}
