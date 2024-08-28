using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using BootCamp_C_Sharp_POO_Na_Patrica.Interfaces;

namespace BootCamp_C_Sharp_POO_Na_Patrica.Models
{
    public class Calculadora : ICalculadora
    {
        public int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}