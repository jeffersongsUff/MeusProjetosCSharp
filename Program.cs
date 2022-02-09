using Calculadora.Classes;
using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            float resultado = 0f;

            Console.WriteLine("Entre com um número para o cálculo:");
            var num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entre com outro número para o cálculo:");
            var num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o sinal da operação:");
            var oper = Console.ReadLine();

            var valida = new ValidaOper();

            if (valida.validaOper(oper))
            {
                ICalcular calculo;
                switch (oper)
                {
                    case "+":
                        calculo = new Somar();
                        resultado = calculo.Calculo(num1, num2);
                        break;
                    case "-":
                        calculo = new Subtrair();
                        resultado = calculo.Calculo(num1, num2);
                        break;
                    case "*":
                        calculo = new Multiplicar();
                        resultado = calculo.Calculo(num1, num2);
                        break;
                    case "/":
                        calculo = new Dividir();
                        resultado = calculo.Calculo(num1, num2);
                        break;
                }
                Console.WriteLine($"O resultado do cálculo é: {resultado}");
            }
        }
    }
}
