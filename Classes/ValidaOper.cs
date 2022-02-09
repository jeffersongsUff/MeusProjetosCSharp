using System;

namespace Calculadora.Classes
{
    class ValidaOper
    {

        public bool validaOper(string oper)
        {
            switch (oper)
            {
                case "+":
                    return true;
                    break;
                case "-":
                    return true;
                    break;
                case "*":
                    return true;
                    break;
                case "/":
                    return true;
                    break;
                default:
                    Console.WriteLine("Operador informado inválido! ");
                    return false;
                    break;
            }
        }
        
    }
}
